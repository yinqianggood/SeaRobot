using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISurvey : UIPage
{
    public UISurvey() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UISurvey";
    }

    public override void Awake(GameObject go)
    {

    }
}

