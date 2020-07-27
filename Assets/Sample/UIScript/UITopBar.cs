using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UITopBar : UIPage {

    Action callback;
    public UITopBar() : base(UIType.Fixed, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UITopbar";
    }

    public override void Awake(GameObject go)
    {
        //this.gameObject.transform.Find("btn_back").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ClosePage();
        //});
        
        UIPage.ShowPage<UIROVMenu>();//default show first page--UIROVMenu.
        
        this.gameObject.transform.Find("TagMenu/tg_ROV Menu").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn)=> { if (isOn) { UIPage.ShowPage<UIROVMenu>(); } });
        this.gameObject.transform.Find("TagMenu/tg_Main Screens").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UIMainScreens>(); } });
        this.gameObject.transform.Find("TagMenu/tg_TMS Displays").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UITMSDisplays>(); } });
        this.gameObject.transform.Find("TagMenu/tg_TMS Menu").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UITMSMenu>(); } });


    }


    void SetTitle(string str)
    {
        this.gameObject.transform.Find("txt_Tittle").GetComponent<Text>().text = str;
    }


}
