﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOperational : UIPage
{

    public UIOperational() : base(UIType.Normal, UIMode.HideOther, UICollider.Normal)
    {
        uiPath = "UIPrefab/UIOperational";
    }

    public override void Awake(GameObject go)
    {

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Operational"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}


