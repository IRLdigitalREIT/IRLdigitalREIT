using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public enum ItemType
{
    Tulip,
    Equipment,
    Resources
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    SupderDuperGiggaRare

}


[CreateAssetMenu(fileName = "Item", menuName = "Items/BaseItem", order = 1)]
public abstract class ItemSO : ScriptableObject
{
    public int id;
    public string itemName;
    public string description;
    public ItemType type;
    public Rarity rarity;
    public Image icon;
    public Item CreateItem()
    {
        Item newItem = new Item();
        return newItem;
    }
}
[System.Serializable]
public class Item
{
    public int id;
    public int count;

    public void AddCount(int _count)
    {
        count += _count;
    }

}