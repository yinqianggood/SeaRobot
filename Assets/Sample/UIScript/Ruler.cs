using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruler : MonoBehaviour
{

    public Text txtValue;
    private float mValue = 0f;
    public Slider SL;
    public bool usePercent = false;
    private void Start()
    {
        txtValue.text = usePercent ? (SL.value * 100 / SL.maxValue).ToString("#0.00") + "%" : SL.value.ToString() + " Bar";
    }
    public void SetValue(float value)
    {
        mValue = value;
        txtValue.text = usePercent ? (value*100 /SL.maxValue).ToString("#0.00") +"%": value.ToString() + " Bar";
    }
    public void OnBtnClick(bool isAdd)
    {
      
        float temp = isAdd ? SL.maxValue / 10f : -SL.maxValue / 10f;
        mValue = mValue + temp;
        if (mValue >= SL.maxValue) mValue = SL.maxValue;
        if (mValue <= SL.minValue) mValue = SL.minValue;
        SL.normalizedValue = mValue / SL.maxValue;
        txtValue.text = usePercent ? (mValue * 100 / SL.maxValue).ToString("#0.00") + "%" :  mValue.ToString() + " Bar";
      
    }
}
