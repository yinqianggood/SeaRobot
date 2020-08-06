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
        this.transform.Find("Btns/btn_ROV Desk").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROVDesk>();
        });
        this.transform.Find("Btns/btn_HCU 1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIHCU1>();
        });
        this.transform.Find("Btns/btn_Survey").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISurvey>();
        });
        this.transform.Find("Btns/btn_Camera Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UICameraControl>();
        });
        this.transform.Find("Btns/btn_Roll Trim").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIRollTrim>();
        });
        this.transform.Find("Btns/btn_Power Resets").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIPowerResets>();
        });
        this.transform.Find("Btns/btn_Cleaning Screen").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UICleaningScreen>();
        });
        this.transform.Find("Btns/btn_HCU 2 HI Flow").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIHCU2HiFlow>();
        });
        this.transform.Find("Btns/btn_ROV Controls").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROVControls>(); 
        });
        this.transform.Find("Btns/btn_Port Manipulator").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIPortManipulatorControls> ();
        });

        this.transform.Find("Btns/btn_Lamp Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UILampControls>();
        });
    }
}