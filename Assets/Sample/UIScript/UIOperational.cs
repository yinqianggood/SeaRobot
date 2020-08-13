using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOperational : UIPage
{

    public UIOperational() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIOperational";
    }

    public override void Awake(GameObject go)
    {

    }
}
