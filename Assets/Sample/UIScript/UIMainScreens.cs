using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScreens :  UIPage
{

    public UIMainScreens() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMainScreens";
    }

    public override void Awake(GameObject go)
    {

    }
}
