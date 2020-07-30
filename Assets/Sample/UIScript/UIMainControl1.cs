using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainControl1 : UIPage
{

    public UIMainControl1() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMain Control1";
    }

    public override void Awake(GameObject go)
    {

    }


}

