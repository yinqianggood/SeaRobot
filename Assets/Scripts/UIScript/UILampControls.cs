using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILampControls : UIPage
{

    public UILampControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UILamp Controls";
    }

    public override void Awake(GameObject go)
    {
        transform.Find("tg_All ROV Lamps").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { SetAllLampOn(isOn); });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Lamp Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
    private void SetAllLampOn(bool isOn)
    {
        for (int i = 1; i <= 6; i++)
        {
            Toggle tg = transform.Find(string.Format("rulers/bg{0}/Toggle{1}", i, i)).GetComponent<Toggle>();
            tg.isOn = isOn;
            for (int j = 1; j <= 2; j++)
            {
                Slider sd = transform.Find(string.Format("rulers/bg{0}/ruler{1}/Slider", i, j)).GetComponent<Slider>();
                sd.normalizedValue = isOn ? 1f : 0f;
            }
           
        }
        
    }

}
