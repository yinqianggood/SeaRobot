using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIROVControls : UIPage
{

    private RobotControl mRC = null;
    private GameObject goRC = null;
    public UIROVControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_Controls";
    }

    public override void Awake(GameObject go)
    {
        Transform t_rov_left = this.transform.Find("bg_right/ROVBody/btn_arrow_left");
        EventTriggerListener.Get(t_rov_left).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_left_on); };
        EventTriggerListener.Get(t_rov_left).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_left_off); };

        Transform t_rov_right = this.transform.Find("bg_right/ROVBody/btn_arrow_right");
        EventTriggerListener.Get(t_rov_right).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_right_on); };
        EventTriggerListener.Get(t_rov_right).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_right_off); };

        Transform t_rov_foward = this.transform.Find("bg_right/ROVBody/btn_arrow_foward");
        EventTriggerListener.Get(t_rov_foward).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_foward_on); };
        EventTriggerListener.Get(t_rov_foward).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_foward_off); };

        Transform t_rov_back= this.transform.Find("bg_right/ROVBody/btn_arrow_back");
        EventTriggerListener.Get(t_rov_back).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_back_on); };
        EventTriggerListener.Get(t_rov_back).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_back_off); };

        Transform t_rov_up= this.transform.Find("bg_right/ROVBody/btn_arrow_up");
        EventTriggerListener.Get(t_rov_up).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_up_on); };
        EventTriggerListener.Get(t_rov_up).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_up_off); };

        Transform t_rov_down = this.transform.Find("bg_right/ROVBody/btn_arrow_down");
        EventTriggerListener.Get(t_rov_down).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_down_on); };
        EventTriggerListener.Get(t_rov_down).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_down_off); };

        Transform t_rov_turnL = this.transform.Find("bg_right/ROVBody/btn_arrow_TrunL");
        EventTriggerListener.Get(t_rov_turnL).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_turn_left_on); };
        EventTriggerListener.Get(t_rov_turnL).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_turn_left_off); };

        Transform t_rov_turnR = this.transform.Find("bg_right/ROVBody/btn_arrow_TrunR");
        EventTriggerListener.Get(t_rov_turnR).onDown += (t) => { UDPClient.instance.Send(NetConfig.rov_turn_right_on); };
        EventTriggerListener.Get(t_rov_turnR).onUp += (t) => { UDPClient.instance.Send(NetConfig.rov_turn_right_on); };




        mRC = GameObject.FindObjectOfType<RobotControl>();
        /*
        this.transform.Find("bg_right/ROVBody/btn_arrow_foward").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
           // mRC.MoveROV(1, 1);
            UDPClient.instance.Send(NetConfig.rov_foward_on);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_back").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
           // mRC.MoveROV(2, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_left").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            // mRC.MoveROV(3, 1);
            UDPClient.instance.Send(NetConfig.rov_left_on);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_right").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
           // mRC.MoveROV(4, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_up").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
           // mRC.MoveROV(5, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_down").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(6, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_TrunL").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(7, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_TrunR").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(8, 1);
        }); 
        */
        this.transform.Find("bg_yuntai/btn_arrow_foward").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.CameraRote(2);
        });
        this.transform.Find("bg_yuntai/btn_arrow_back").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.CameraRote(1);
        });
        this.transform.Find("bg_yuntai/btn_arrow_left").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.CameraRote(3);
        });
        this.transform.Find("bg_yuntai/btn_arrow_right").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.CameraRote(4);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnOut").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(8);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnIn").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(7);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnL").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(9);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnR").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(10);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnLong").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(5); ;
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnShort").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(6);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Up").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(3);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Down").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(4);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Left").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(1);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Right").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.ArmControl(2);
        });
        this.transform.Find("middle/btn_flot_up").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.FlotControl(false);
        });
        this.transform.Find("middle/btn_flot_down").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.FlotControl(true);
        });
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
        //goRC = GameObject.Instantiate(Resources.Load("RobotControl")) as GameObject;
        //mRC = goRC.GetComponent<RobotControl>();


    }

    public override void Hide()
    {
        base.Hide();
        GameObject.Destroy(goRC);
    }
}
