using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScreens :  UIPage
{

    public UIMainScreens() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMainScreens";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("btn_Operactional").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIOperational>();
        });
        this.transform.Find("btn_Flying").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIFlying>();
        });
        this.transform.Find("btn_System Status").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISystemStatus>();
        });
        this.transform.Find("btn_Alarm Summary").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIAlarmSummary>();
        });
    }
}
