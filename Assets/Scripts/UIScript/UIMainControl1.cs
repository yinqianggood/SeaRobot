using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainControl1 : UIPage
{

    public UIMainControl1() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMain Control1";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("bg_left/tgs/tg_LoadPump").GetComponent<Toggle>().onValueChanged.AddListener(
           (bool isOn) => { ControlData.Instance.LoadPump_isOn = isOn ? 1 : 0; });
        this.transform.Find("bg_left/tgs/tg_Thrust Enable").GetComponent<Toggle>().onValueChanged.AddListener(
          (bool isOn) => { ControlData.Instance.ThrustEnabled_isOn = isOn ? 1 : 0; });
        this.transform.Find("bg_left/tgs/tg_STBD Mainipulator").GetComponent<Toggle>().onValueChanged.AddListener(
          (bool isOn) => { ControlData.Instance.STBDMainipulator_isOm = isOn ? 1 : 0; });
        this.transform.Find("bg_left/ruler/Slider").GetComponent<Slider>().onValueChanged.AddListener((float value) =>
        {
            ControlData.Instance.SystemPressureValue_isOn = value > 0 ? 1 : 0;
        });
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Main Control1"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }


}

