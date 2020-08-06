using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROVControls : UIPage
{

    public UIROVControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV Controls";
    }

    public override void Awake(GameObject go)
    {

    }
}
