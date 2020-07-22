using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIControlMenu : UIPage
{

    public UIControlMenu() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIControlMenu";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("ROVMenu/Btns/btn_System Start").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISystemStart>();
        });
    }

   
}
