using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRollTrim : UIPage
{
    public UIRollTrim() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIRollTrim";
    }

    public override void Awake(GameObject go)
    {

    }
}