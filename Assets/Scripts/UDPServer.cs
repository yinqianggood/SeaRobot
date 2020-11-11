using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class UDPServer : MonoBehaviour
{
    public string recvStr;
    Socket socket;
    EndPoint clientEnd;
    IPEndPoint ipEnd;

    byte[] recvData = new byte[1024];
    byte[] sendData = new byte[1024];
    int recvLen;
    Thread connectThread;

    public static UDPServer instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void  InitSocket()
    {
        ipEnd = new IPEndPoint(IPAddress.Any, 8888);
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        socket.Bind(ipEnd);

        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        clientEnd = (EndPoint)sender;

        connectThread = new Thread(new ThreadStart(SocketReceive));
        connectThread.Start();
    }

    void SocketSend(string sendStr)
    {
        sendData = new byte[1024];
        sendData = Encoding.UTF8.GetBytes(sendStr);
        socket.SendTo(sendData,sendData.Length,SocketFlags.None,clientEnd);
    }

    void SocketReceive()
    {
        while(true)
        {
            recvData = new byte[1024];
            recvLen = socket.ReceiveFrom(recvData, ref clientEnd);
            print("connected:"+clientEnd.ToString());
            recvStr = Encoding.UTF8.GetString(recvData,0,recvLen);

        }
    }

    void SocketQuit()
    {
        if(connectThread!=null)
        {
            connectThread.Interrupt();
            connectThread.Abort();
        }
        if(socket!=null)
        {
            socket.Close();
        }
        print("disconnected！");
    }
    // Start is called before the first frame update
    void Start()
    {
        InitSocket();
    }

    private void OnApplicationQuit()
    {
        SocketQuit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
