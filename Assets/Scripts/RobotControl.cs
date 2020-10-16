using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour
{
    public GameObject ROV;
    public GameObject TMS;
    public GameObject armNote1;
    public GameObject armNode2;
    public GameObject armNode3;
    public GameObject armNodeRote;
    public GameObject armFinger1;
    public GameObject armFinger2;

    public List<Transform> H_Propellers = new List<Transform>();
    public List<Transform> V_Propellers = new List<Transform>();
    private float mPropSpeed = 1000;

    public List<GameObject> lamp_port_STBD;
    public List<GameObject> lamp_bullet_PT;
    public List<GameObject> lamp_bottomPT;
    public Light light_bullet;
    public Light light_pt;
    public Light light_pt_bottom;
    public Light light_port;
    public Light light_STBD;
  


    public GameObject PT_RoteteH;
    public GameObject PT_RoteteV;
    public GameObject PT_BottomRoteteH;
    public GameObject PT_BottomRotateV;

    public GameObject flotPan;

    //作为单例类
    private static RobotControl instance;
    public static RobotControl Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RobotControl();
            }
            return instance;
        }
    }

    public enum DIR
    { 
       None=0,
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
       // LampControl(true,false,true,true);
        //lamp_bottomPT[0].gameObject.GetComponent<MeshRenderer>().sharedMaterial.DisableKeyword("_EMISSION");
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
                MsgMng.Instance.Send(MessageName.MSG_MOVE_LEFT, new MessageData((int)DIR.Left));
                break;
            case DIR.Right:
                ROV.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_RIGHT, new MessageData((int)DIR.Right));
                break;
            case DIR.Foward:
                ROV.transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_FWD, new MessageData((int)DIR.Foward));
                break;
            case DIR.Back:
                ROV.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_BWD, new MessageData((int)DIR.Back));
                break;
            case DIR.Up:
                ROV.transform.Translate(new Vector3(0, speed * Time.deltaTime,0));
                ThrusterControl(mPropSpeed, PROPDIR.Vertical);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_UP, new MessageData((int)DIR.Up));
                break;
            case DIR.Down:
                // _rb.velocity = transform.forward* Time.deltaTime * 2;
                //ROV.transform.position -= transform.up * Time.deltaTime * speed;
                ROV.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Vertical);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_DOWN, new MessageData((int)DIR.Down));
                break;
            case DIR.TurnL:
                ROV.transform.Rotate(new Vector3(0, -speed * 5 * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_TURN_L, new MessageData((int)DIR.TurnL));
                break;
            case DIR.TurnR:
                ROV.transform.Rotate(new Vector3(0, speed* 5 * Time.deltaTime, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_TURN_R, new MessageData((int)DIR.TurnR));
                break;
            default:
                break;
        }
    }

    public void CameraRote(int direct)
    {
        GameObject ptH = ControlData.Instance.curPT == 1 ? PT_RoteteH : PT_BottomRoteteH;
        GameObject ptV = ControlData.Instance.curPT == 1 ? PT_RoteteV : PT_BottomRotateV;
        DIR dir = (DIR)direct;
        switch (dir)
        {
            case DIR.Foward:
                ptV.transform.Rotate(new Vector3(5 * Time.deltaTime, 0, 0));
                break;
            case DIR.Back:
                ptV.transform.Rotate(new Vector3(-5 * Time.deltaTime, 0, 0));
                break;
            case DIR.Left:
                ptH.transform.Rotate(new Vector3(0, -5 * Time.deltaTime, 0));
                break;
            case DIR.Right:
                ptH.transform.Rotate(new Vector3(0,  5 * Time.deltaTime, 0));
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
                armNode2.transform.Rotate(new Vector3(0, 0,10 * Time.deltaTime));
                break;
            case ARMDIR.Down:
                armNode2.transform.Rotate(new Vector3(0, 0, -10 * Time.deltaTime));
                break;
            case ARMDIR.Long:
                if(armNode3.transform.localPosition.y<0.65f)
                {
                    armNode3.transform.Translate(0, 0.05f * Time.deltaTime, 0);
                }
                break;
            case ARMDIR.Short:
                if (armNode3.transform.localPosition.y >0.4f)
                {
                    armNode3.transform.Translate(0, -0.05f * Time.deltaTime, 0);
                }
                break;
            case ARMDIR.In:
                Vector3 v3 = getAngle(armFinger1.transform);
                Debug.Log("v3.x:" + v3.x);
                if (v3.x >20f) return;
                armFinger1.transform.Rotate(new Vector3(-10f * Time.deltaTime, 0, 0));
                armFinger2.transform.Rotate(new Vector3(-10f * Time.deltaTime, 0, 0));
                break;
            case ARMDIR.Out:
                Vector3 v = getAngle(armFinger1.transform);
                if (v.x < -30f) return;
                armFinger1.transform.Rotate(new Vector3(10f * Time.deltaTime, 0, 0));
                armFinger2.transform.Rotate(new Vector3(10f * Time.deltaTime, 0, 0));
                break;
            case ARMDIR.TurnL:
                armNodeRote.transform.Rotate(new Vector3(0,-10*Time.deltaTime,0));
                break;
            case ARMDIR.TurnR:
                armNodeRote.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
                break;
            default:
                break;
        }
    }

    Vector3 getAngle(Transform t)
    {
        Vector3 angle = t.eulerAngles;
        float x = angle.x;
        float y = angle.y;
        float z = angle.z;
        if (Vector3.Dot(transform.up,Vector3.up)>=0f)
        {
            if(angle.x>=0f&&angle.x<=90f)
            {
                x = angle.x;
            }
            if(angle.x>=270f && angle.x<=360f)
            {
                x = angle.x - 360f;
            }
        }
        if (Vector3.Dot(transform.up, Vector3.up) < 0)
        {
            if (angle.x >= 0f && angle.x <= 90f)
            {
                x = 180f - angle.x;
            }
            if (angle.x >= 270f && angle.x <= 360f)
            {
                x = 180f - angle.x;
            }
        }
        if (angle.y > 180)
        {
            y = angle.y - 360f;
        }
        if (angle.z > 180)
        {
            y = angle.z - 360f;
        }
        return new Vector3(x, y, z);
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

    public  void LampControl(bool showPortSTBD,bool showBulletPT,bool showBottomPT,bool showAll)
    {
        light_port.gameObject.SetActive(showPortSTBD || showAll);
        light_STBD.gameObject.SetActive(showPortSTBD || showAll);
        light_bullet.gameObject.SetActive(showBulletPT || showAll);
        light_pt.gameObject.SetActive(showBulletPT || showAll);
        light_pt_bottom.gameObject.SetActive(showBottomPT || showAll);
        for (int i = 0; i < lamp_port_STBD.Count; i++)
            {
                if (showPortSTBD || showAll)
                    lamp_port_STBD[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                else
                    lamp_port_STBD[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            }

            for (int i = 0; i < lamp_bullet_PT.Count; i++)
            {
                
                if (showBulletPT || showAll)
                    lamp_bullet_PT[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                else
                    lamp_bullet_PT[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            }

            for (int i = 0; i < lamp_bottomPT.Count; i++)
            {
               
                if(showBottomPT || showAll)
                    lamp_bottomPT[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                else
                    lamp_bottomPT[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            }
        }

    public void FlotControl(bool isIn)
    {
      float speed=isIn ? -1:1;
        if (flotPan.transform.localPosition.z > 1)
        {
            flotPan.transform.localPosition = new Vector3(flotPan.transform.localPosition.x, flotPan.transform.localPosition.y, 1);
        }
        else if (flotPan.transform.localPosition.z < 0)
        {
            flotPan.transform.localPosition = new Vector3(flotPan.transform.localPosition.x, flotPan.transform.localPosition.y, 0);
        }
        else
            flotPan.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));


        
      
    }

       
    }





