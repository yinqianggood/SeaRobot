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

    }
}
