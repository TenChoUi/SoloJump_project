using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar; 
    
    void Start()
    {
        curValue = startValue;
    }
    
    void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }

    public void Add(float amount)
    {
        curValue = Mathf.Clamp(curValue + amount, startValue, maxValue);
    }

    public void Abstract(float amount)
    {
        curValue = Mathf.Clamp(curValue - amount, 0,0f);
    }
    private float GetPercentage()
    {
        return curValue / maxValue;
    }
}
