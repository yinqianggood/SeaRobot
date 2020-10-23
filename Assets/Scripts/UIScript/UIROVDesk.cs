using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIROVDesk : UIPage
{
    public UIROVDesk() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROVDesk";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("bg1/img_pod/tg_start").GetComponent<Toggle>().onValueChanged.AddListener(
            (bool isOn) => { ControlData.Instance.ROVPOD_isOn = isOn ? 1 : 0; });
        this.transform.Find("bg1/img_motor/tg_start").GetComponent<Toggle>().onValueChanged.AddListener(
            (bool isOn) => { ControlData.Instance.ROVMOTOR_isOn = isOn ? 1 : 0; });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Desk"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
