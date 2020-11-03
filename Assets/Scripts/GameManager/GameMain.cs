using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameMain : MonoBehaviour {

	// Use this for initialization
	public Light directLight;
	void Start () {
       
        UIPage.ShowPage<UITopBar>();

        // var root = UIRoot.Instance;
        for (int i = 0; i < Display.displays.Length; i++)
        {
			Display.displays[i].Activate();
        }
		


	}
	
	// Update is called once per frame
	void Update () {
		directLight.intensity = ControlData.Instance.ALLROVLAMP_isOn;
	}

}
