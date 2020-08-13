using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAlarmSummary : UIPage
{

    public UIAlarmSummary() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIAlarmSummary";
    }

    public override void Awake(GameObject go)
    {

    }
}
