using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Itemtype
{
    Consumable,
    Resource
}

public enum ConsumableType
{
    Heatlth,
    Stemina
}

[SerializeField]
public class ItemDataCosumnable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayname;
    public string description;
    public Itemtype type;
    public Sprite icon;
    public GameObject dropprefab;
    
    [Header("Stacking")]
    public bool CanStack;
    public int maxStackAmount;
    
    [Header("Consumable")]
    public ItemDataCosumnable[] consumables;
    
}
