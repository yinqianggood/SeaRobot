﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAutoSpeed_Tracking : UIPage
{

    public UIAutoSpeed_Tracking() : base (UIType.Normal, UIMode.HideOther, UICollider.None)
{
    uiPath = "UIPrefab/UIAuto Speed_Tracking";
}

public override void Awake(GameObject go)
{

}
}
