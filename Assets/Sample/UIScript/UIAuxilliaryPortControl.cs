using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAuxilliaryPortControl : UIPage
{

    public UIAuxilliaryPortControl() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIAuxilliary Port Control";
    }

    public override void Awake(GameObject go)
    {

    }
}
