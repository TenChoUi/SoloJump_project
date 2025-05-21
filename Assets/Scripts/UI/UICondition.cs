using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    public UICondition uiCcondition;
    
    Condition health { get { return uiCcondition.health; } }
    Condition stamina { get { return uiCcondition.stamina; } }
    
    public event Action OnTakeDamage;

    private void Update()
    {
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if (health.curValue < 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    private void Die()
    {
        Debug.Log("플레이어가 죽었다!");
    }
}
