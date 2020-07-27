using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITMSMenu : UIPage
{

    public UITMSMenu() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UITMS Menu";
    }

    public override void Awake(GameObject go)
    {

    }
}
