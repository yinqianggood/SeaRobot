using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour
{
    public GameObject ROV;
    public GameObject TMS;
    public GameObject cam_Pan_Tilt;
    public GameObject armNote1;
    public GameObject armNode2;
    public GameObject armNodeRote;
    public GameObject armFinger1;
    public GameObject armFinger2;

    public List<Transform> propellers;

    public enum DIR
    { 
       Foward=1,
       Back=2,
       Left=3,
       Right=4,
       Up=5,
       Down=6,
       TurnL=7,
       TurnR=8
    }
    private Rigidbody _rb ;
    private void Awake()
    {
        _rb = ROV.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ThrusterControl(300);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveROV(int direct,float speed=1,Boolean isPress=true)
    {
      
        DIR dir = (DIR)direct;
        switch (dir)
        {
            case DIR.Foward:
                ROV.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                break;
            case DIR.Back:
                ROV.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                break;
            case DIR.Left:
                ROV.transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
                break;
            case DIR.Right:
                ROV.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                break;
            case DIR.Up:
                ROV.transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
                break;
            case DIR.Down:
                // _rb.velocity = transform.forward* Time.deltaTime * 2;
                //ROV.transform.position -= transform.up * Time.deltaTime * speed;
                ROV.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
                break;
            case DIR.TurnL:
                ROV.transform.Rotate(new Vector3(0, -speed * 5 * Time.deltaTime, 0));
                break;
            case DIR.TurnR:
                ROV.transform.Rotate(new Vector3(0, speed* 5 * Time.deltaTime, 0));
                break;
            default:
                break;
        }
       


    }

    public void CameraRote(int direct)
    {
        DIR dir = (DIR)direct;
        switch (dir)
        {
            case DIR.Foward:
                cam_Pan_Tilt.transform.Rotate(new Vector3(5 * Time.deltaTime, 0, 0));
                break;
            case DIR.Back:
                cam_Pan_Tilt.transform.Rotate(new Vector3(-5 * Time.deltaTime, 0, 0));
                break;
            case DIR.Left:
                cam_Pan_Tilt.transform.Rotate(new Vector3(0, -5 * Time.deltaTime, 0));
                break;
            case DIR.Right:
                cam_Pan_Tilt.transform.Rotate(new Vector3(0,  5 * Time.deltaTime, 0));
                break;
            default:
                break;
        }
    }

    private void ThrusterControl(float speed)
    {
        //for (int i = 0; i < propellers.Count; i++)
        //{
        //    propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
           
        //}
    }
}
