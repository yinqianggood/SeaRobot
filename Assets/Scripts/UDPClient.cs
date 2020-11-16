using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class UDPClient : MonoBehaviour
{

    public static UDPClient instance;
    public string recvStr;
    public string UDPClientIP;
    public Socket socket;
    EndPoint serverEnd;
    IPEndPoint ipEnd;

    byte[] recvData = new byte[1024];
    byte[] sendData = new byte[1024];
    int recvLen = 0;
    Thread connectThread;

     void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UDPClientIP = "127.0.0.1";
        UDPClientIP = UDPClientIP.Trim();
        Debug.Log("Connect Ip:"+UDPClientIP);
        InitSocket();
    }

    void InitSocket()
    {
        ipEnd = new IPEndPoint(IPAddress.Parse(UDPClientIP), 8888);
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        serverEnd = (EndPoint)sender;
        SocketSend("SeaRobot");
        connectThread = new Thread(new ThreadStart(SocketReceive));
        connectThread.Start();
        
    }
    void SocketSend(string sendStr)
    {
        sendData = new byte[1024];
        sendData = Encoding.UTF8.GetBytes(sendStr);
        socket.SendTo(sendData, sendData.Length, SocketFlags.None, ipEnd);

    }

    void SocketReceive()
    {
        while(true)
        {
            recvData = new byte[1024];
            try
            {
                recvLen = socket.ReceiveFrom(recvData,ref serverEnd);
                if(recvLen>0)
                {
                    recvStr = Encoding.UTF8.GetString(recvData, 0, recvLen);
                    Debug.Log("Client receive:"+recvStr);
                }
            }
            catch(SocketException ex)
            {
                Debug.LogError("Client Receive Fail:"+ex.ToString());
            }
            Debug.Log("message from:"+serverEnd.ToString());
           
        }
    }
    void SocketQuit()
    {
        if(connectThread!=null)
        {
            connectThread.Interrupt();
            connectThread.Abort();
        }
        if (socket != null)
            socket.Close();
    }
   
    public void Send(string data)
    {
        SocketSend(data);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
