using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruler2 : MonoBehaviour
{

    public Text txtValue;
    private float mValue = 0f;
    public Slider SL;
    public void SetValue(float value)
    {
        mValue = value;
        txtValue.text = value.ToString() + " Units";
    }
    public void OnBtnClick(bool isAdd)
    {

        float temp = isAdd ? SL.maxValue / 1f : -SL.maxValue / 1f;
        mValue = mValue + temp;
        if (mValue >= SL.maxValue) mValue = SL.maxValue;
        if (mValue <= SL.minValue) mValue = SL.minValue;
        SL.normalizedValue = mValue / SL.maxValue;
        txtValue.text = mValue.ToString() + " Units";

    }
}