using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHCU1 : UIPage
{
    public UIHCU1() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIHCU1";
    }

    public override void Awake(GameObject go)
    {

    }
}