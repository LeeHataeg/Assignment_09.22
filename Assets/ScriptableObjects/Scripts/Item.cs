using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Shield,
    Food
}

[CreateAssetMenu(fileName = "DefaultItemData", menuName = "TotalItem/Item/DefaultItem")]
public class Item : ScriptableObject
{
    public ItemType type;

    [Header("Item Info")]
    public string item_Name;
    public int item_Gold;
    public string item_Dicription;
    public Sprite item_Sprite;

    [Header("Item Stats")]
    public float item_Atk;
    public float item_Def;
    public float item_Hp;
    public float item_Cri;
}
