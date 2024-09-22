using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    List<Item> items;
    ItemSO[] itemTypes;
    public void AddItem(ItemSO _item, int _count)
    {
        foreach (Item i in items)
        {
            if (i.id == _item.id)
            {
                i.AddCount(_count);
                return;
            }
        }

        Item newItem = _item.CreateItem();
        newItem.id = _item.id;
        newItem.count = _count;
        items.Add(newItem);
    }
}
