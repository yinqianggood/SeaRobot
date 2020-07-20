﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIMainPage : UIPage {

    public UIMainPage() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMain";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("btn_skill").GetComponent<Button>().onClick.AddListener(() =>
        {
            ShowPage<UISkillPage>();
        });

        this.transform.Find("btn_battle").GetComponent<Button>().onClick.AddListener(() =>
        {
          //  ShowPage<UIBattle>();
            ShowPage<UIControlMenu>();
        });
    }


}
