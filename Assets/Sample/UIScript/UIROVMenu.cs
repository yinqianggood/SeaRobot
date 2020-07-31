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
        this.transform.Find("Btns/btn_Main Control1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIMainControl1>();
        });
        this.transform.Find("Btns/btn_Main Control2").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIMainControl2>();
        });
        this.transform.Find("Btns/btn_Pilot Flight").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIPilotFightScreen>();
        });
    }
}