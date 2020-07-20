using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITopBar : UIPage {

    public UITopBar() : base(UIType.Fixed, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/Topbar";
    }

    public override void Awake(GameObject go)
    {
        this.gameObject.transform.Find("btn_back").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ClosePage();
        });

        this.gameObject.transform.Find("btn_notice").GetComponent<Button>().onClick.AddListener(() =>
        {
            ShowPage<UINotice>();
        });
      
    }


}
