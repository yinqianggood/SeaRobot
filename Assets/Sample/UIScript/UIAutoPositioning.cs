﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAutoPositioning : UIPage
{

    public UIAutoPositioning() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIAuto Positioning";
    }

    public override void Awake(GameObject go)
    {

    }
}
