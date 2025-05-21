using System;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    public Condition health;
    public Condition stemina;

    private void Start()
    {
        CharterManager.Instance.Player.Condition.uiCcondition = this;
    }
}
