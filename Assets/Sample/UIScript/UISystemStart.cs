using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UISystemStart : UIPage
{

    public UISystemStart() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UISystemStart";
    }

    public override void Awake(GameObject go)
    {
      
    }

   
}
