using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Control_TagMenu : MonoBehaviour
{

   public List<UnityEngine.UI.Toggle> togsMenu = new List<UnityEngine.UI.Toggle > ();
   public  List<GameObject> togPages = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < togsMenu.Count; i++)
        {
            int a = i;
            togsMenu[a].onValueChanged.AddListener((bool isOn) => { togPages[a].SetActive(isOn); });
        }
    }

    public void OnToggleValueChange(bool  isOn)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
