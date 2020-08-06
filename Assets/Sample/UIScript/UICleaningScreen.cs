using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICleaningScreen : UIPage
{
    public UICleaningScreen() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UICleaningScreen";
    }

    public override void Awake(GameObject go)
    {

    }
}
