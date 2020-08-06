using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPowerResets : UIPage
{
    public UIPowerResets() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIPowerResets";
    }

    public override void Awake(GameObject go)
    {

    }
}
