﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHCU2HiFlow: UIPage
{
    public UIHCU2HiFlow() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIHCU2HiFlow";
    }

    public override void Awake(GameObject go)
    {

    }
}
