using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruler1 : MonoBehaviour
{

    public Text txtValue;
    private float mValue = 0f;
    public Slider SL;
    public void SetValue(float value)
    {
        mValue = value;
        txtValue.text = value.ToString() + " %";
    }
    public void OnBtnClick(bool isAdd)
    {

        float temp = isAdd ? SL.maxValue / 100f : -SL.maxValue / 100f;
        mValue = mValue + temp;
        if (mValue >= SL.maxValue) mValue = SL.maxValue;
        if (mValue <= SL.minValue) mValue = SL.minValue;
        SL.normalizedValue = mValue / SL.maxValue;
        txtValue.text = mValue.ToString() + " %";

    }
}