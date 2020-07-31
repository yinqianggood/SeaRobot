using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPilotFightScreen : UIPage
{

    public UIPilotFightScreen() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIPilot Fight Screen";
    }

    public override void Awake(GameObject go)
    {

    }
}
