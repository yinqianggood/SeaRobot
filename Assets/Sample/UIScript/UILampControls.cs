using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILampControls : UIPage
{

    public UILampControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UILamp Controls";
    }

    public override void Awake(GameObject go)
    {

    }
}
