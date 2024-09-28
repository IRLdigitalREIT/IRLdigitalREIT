using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
  
    InventorySlot[] itemSlots;
    public void AddItem(ItemSO _item, int _count)
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (itemSlots[i].empty)
            {
                itemSlots[i].SetItem(_item.CreateItem());
            }
        }
    /*    foreach (Item i in items)
        {
            if (i.id == _item.id)
            {
                i.AddCount(_count);
                return;
            }
        }

        Item newItem = _item.CreateItem();

        items.Add(newItem);*/
    }
}
public class InventorySlot : MonoBehaviour
{
   public bool empty = true;
    Item item;

    public void SetItem(Item _item)
    {
        item = _item;
    }
}