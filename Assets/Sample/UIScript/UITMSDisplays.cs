using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITMSDisplays : UIPage
{

    public UITMSDisplays() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UITMS Displays";
    }

    public override void Awake(GameObject go)
    {

    }
}
