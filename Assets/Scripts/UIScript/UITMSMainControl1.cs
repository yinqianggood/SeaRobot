using System.Collections;
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

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS Main Control1"));
    }
}