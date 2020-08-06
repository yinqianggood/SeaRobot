using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICameraControl : UIPage
{
    public UICameraControl() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UICameraControl";
    }

    public override void Awake(GameObject go)
    {

    }
}
