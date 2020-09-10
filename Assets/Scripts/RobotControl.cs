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

    public List<Transform> H_Propellers = new List<Transform>();
    public List<Transform> V_Propellers = new List<Transform>();
    private float mPropSpeed = 500;

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

    public enum PROPDIR 
    {
      Horizontal=1,
      Vertical=2,
      Both=3

    }

    public enum ARMDIR 
    {
      Left=1,
      Right=2,
      Up=3,
      Down=4,
      Long=5,
      Short=6,
      In=7,
      Out=8,
      TurnL = 9,
      TurnR = 10,
    }
    private Rigidbody _rb ;
    private void Awake()
    {
        _rb = ROV.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
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
            case DIR.Left:
                ROV.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                break;
            case DIR.Right:
                ROV.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                break;
            case DIR.Foward:
                ROV.transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                break;
            case DIR.Back:
                ROV.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                break;
            case DIR.Up:
                ROV.transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
                ThrusterControl(mPropSpeed, PROPDIR.Vertical);
                break;
            case DIR.Down:
                // _rb.velocity = transform.forward* Time.deltaTime * 2;
                //ROV.transform.position -= transform.up * Time.deltaTime * speed;
                ROV.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Vertical);
                break;
            case DIR.TurnL:
                ROV.transform.Rotate(new Vector3(0, -speed * 5 * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                break;
            case DIR.TurnR:
                ROV.transform.Rotate(new Vector3(0, speed* 5 * Time.deltaTime, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
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
    public void ArmControl(int dir)
    {
        ARMDIR ad = (ARMDIR)dir;
        switch (ad)
        {
            case ARMDIR.Left:
                armNote1.transform.Rotate(new Vector3(0, -10 * Time.deltaTime,0));
                break;
            case ARMDIR.Right:
                armNote1.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
                break;
            case ARMDIR.Up:
                armNote1.transform.Rotate(new Vector3(0, 0,10 * Time.deltaTime));
                break;
            case ARMDIR.Down:
                armNote1.transform.Rotate(new Vector3(0, 0, -10 * Time.deltaTime));
                break;
            case ARMDIR.Long:
                if(armNode2.transform.localPosition.y<0.45f)
                {
                    armNode2.transform.Translate(0, 0.05f * Time.deltaTime, 0);
                }
                break;
            case ARMDIR.Short:
                if (armNode2.transform.localPosition.y >0.3f)
                {
                    armNode2.transform.Translate(0, -0.05f * Time.deltaTime, 0);
                }
                break;
            case ARMDIR.In:
                armFinger1.transform.Rotate(new Vector3(10f * Time.deltaTime, 0, 0));
                armFinger2.transform.Rotate(new Vector3(-10f * Time.deltaTime, 0, 0));
                break;
            case ARMDIR.Out:
                armFinger1.transform.Rotate(new Vector3(-10f * Time.deltaTime, 0, 0));
                armFinger2.transform.Rotate(new Vector3(10f * Time.deltaTime, 0, 0));
                break;
            case ARMDIR.TurnL:
                armNodeRote.transform.Rotate(new Vector3(0,10*Time.deltaTime,0));
                break;
            case ARMDIR.TurnR:
                armNodeRote.transform.Rotate(new Vector3(0, -10 * Time.deltaTime, 0));
                break;
            default:
                break;
        }
    }

    private void ThrusterControl(float speed,PROPDIR pd)
    {
        if(pd!=PROPDIR.Vertical)
        {
            for (int i = 0; i < H_Propellers.Count; i++)
            {
                H_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
            }
        }
        
        if(pd!=PROPDIR.Horizontal)
        {
            for (int i = 0; i < V_Propellers.Count; i++)
            {
                V_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
            }
        }
       
    }

    
}
