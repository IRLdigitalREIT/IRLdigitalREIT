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
public class ItemSO : ScriptableObject
{
    public int id;
    public string itemName;
    public string description;
    public ItemType type;
    public Rarity rarity;
    public Image icon;
    public Item CreateItem()
    {
        Item newItem = new Item(this);

        return newItem;
    }
}

[System.Serializable]
public class Item : MonoBehaviour
{
    public int id;
    public string itemName;
    public string description;
    public ItemType type;
    public Rarity rarity;
    public Image icon;
    public Item(ItemSO item)
    {
        id = item.id;
        itemName = item.name;
        description = item.description;
        type = item.type; 
        rarity = item.rarity;
        icon = item.icon;  

    }

}