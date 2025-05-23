using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController Controller;
    public PlayerCondition Condition;
    public ItemData ItemData { get; set; }
    public object addItem { get; set; }

    private void Awake()
    {
        CharterManager.Instance.Player = this;
        Controller = GetComponent<PlayerController>();
        Condition = GetComponent<PlayerCondition>();
    }
}

