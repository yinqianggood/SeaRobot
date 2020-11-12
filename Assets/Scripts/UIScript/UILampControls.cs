using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILampControls : UIPage
{
    private RobotControl rc;
    private Toggle tg1, tg2, tg3, tgAll;
    public UILampControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UILamp Controls";
    }

    public override void Awake(GameObject go)
    {
        rc = GameObject.FindObjectOfType<RobotControl>();
        tg1 = transform.Find("rulers/bg1/Toggle1").GetComponent<Toggle>();
        tg2 = transform.Find("rulers/bg2/Toggle2").GetComponent<Toggle>();
        tg3 = transform.Find("rulers/bg3/Toggle3").GetComponent<Toggle>();
        tgAll = transform.Find("tg_All ROV Lamps").GetComponent<Toggle>();
        tgAll.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn,4); });
        tg1.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 1); });
        tg2.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 2); });
        tg3.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 3); });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Lamp Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
      
    }
    private void SetLamp(bool isOn,int type)
    {
       // rc.LampControl(tg1.isOn, tg2.isOn, tg3.isOn, tgAll.isOn);
        if (type==1)
        {
            string strdata = tg1.isOn ? NetConfig.lamp_port_stbd_on : NetConfig.lamp_port_stbd_off;
            UDPClient.instance.Send(strdata);
        }
        else if(type==2)
        {
            string strdata = tg2.isOn ? NetConfig.lamp_bullet_pt_on : NetConfig.lamp_bullet_pt_off;
            UDPClient.instance.Send(strdata);
        }
        else if (type == 3)
        {
            string strdata = tg3.isOn ? NetConfig.lamp_bottom_pt_on : NetConfig.lamp_bottom_pt_off;
            UDPClient.instance.Send(strdata);
        }
       else
        {
            string strdata = tgAll.isOn ? NetConfig.lamp_all_on : NetConfig.lamp_all_off;
            UDPClient.instance.Send(strdata);
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
        ControlData.Instance.ALLROVLAMP_isOn = (tg1.isOn || tg2.isOn || tg3.isOn || tgAll.isOn) ? 1 : 0;

    }

   
   // {
   //     Debug.Log(tg1.isOn + "   " + tg2.isOn + "   " + tg3.isOn + "  " + tgAll.isOn);
   //     rc.LampControl(tg1.isOn, tg2.isOn, tg3.isOn, tgAll.isOn);
   // }

}
