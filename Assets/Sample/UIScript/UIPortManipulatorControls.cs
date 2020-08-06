using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPortManipulatorControls : UIPage
{

    public UIPortManipulatorControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIPort Manipulator Controls";
    }

    public override void Awake(GameObject go)
    {

    }
}
