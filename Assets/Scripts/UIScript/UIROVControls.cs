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
       
       
        this.transform.Find("bg_right/ROVBody/btn_arrow_foward").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(1, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_back").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(2, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_left").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(3, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_right").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(4, 1);
        });
        this.transform.Find("bg_right/ROVBody/btn_arrow_up").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            mRC.MoveROV(5, 1);
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
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
        goRC = GameObject.Instantiate(Resources.Load("RobotControl")) as GameObject;
        mRC = goRC.GetComponent<RobotControl>();


    }

    public override void Hide()
    {
        base.Hide();
        GameObject.Destroy(goRC);
    }
}
