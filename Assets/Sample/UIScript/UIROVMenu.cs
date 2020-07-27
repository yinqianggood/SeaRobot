using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIROVMenu : UIPage
{

    public UIROVMenu() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROVMenu";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("Btns/btn_System Start").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISystemStart>();
        });
    }
}