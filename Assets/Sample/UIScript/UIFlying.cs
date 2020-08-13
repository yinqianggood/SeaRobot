using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFlying : UIPage
{

    public UIFlying() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIFlying";
    }

    public override void Awake(GameObject go)
    {

    }
}
