using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartMenu : UIPage
{

    public UIStartMenu() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIStartMenu";
    }

    public override void Awake(GameObject go)
    {

        this.transform.Find("Btns/btn_Main Control1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIMainControl1>();
        });
        this.transform.Find("Btns/btn_TMS Main Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UITMSMainControl1>();
        });

        this.transform.Find("Btns/btn_ROV Desk").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROVDesk>();

        });
        this.transform.Find("Btns/btn_Lamp Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UILampControls>();
        });
        
        this.transform.Find("btn_ROVControl").GetComponent<Button>().onClick.AddListener(() =>
        {
            
          //  if (ControlData.Instance.GetReady)
            UIPage.ShowPage<UIROVControls>();
        });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Menu"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
       // this.transform.Find("btn_ROVControl/txt_warning").gameObject.SetActive(!ControlData.Instance.GetReady);
    }
}
