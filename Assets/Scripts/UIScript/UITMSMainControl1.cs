﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITMSMainControl1 : UIPage
{
    public UITMSMainControl1() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UITMSMainControl1";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("bg_left/btn_release_sequence").GetComponent<Button>().onClick.AddListener(
           () => { ControlData.Instance.Release_Sequence_isOn = 1; });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS Main Control1"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}