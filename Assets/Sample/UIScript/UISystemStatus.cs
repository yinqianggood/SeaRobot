using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystemStatus : UIPage
{

    public UISystemStatus() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UISystemStatus";
    }

    public override void Awake(GameObject go)
    {

    }
}
