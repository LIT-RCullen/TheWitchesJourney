using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, IDataPersistance
{
    public static Inventory InstanceInventory;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;

    public List<Item> items = new List<Item>();

    ListSlot questItem;


    void Awake ()
    {
        if (InstanceInventory != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        InstanceInventory = this;

    }

    public void LoadData(GameData data)
    {
        items = data.inventory;
        
        for (int i = 0; i < items.Count; i++)
        {
            Add(items[i]);
        }
    }

    public void SaveData(ref GameData data)
    {
        data.inventory = items;
    }


    public bool Add (Item item)
    {
        if (QuestList.InstanceQuestList.Qitems.Contains(item))
        {
            questItem = QuestList.InstanceQuestList.slots[QuestList.InstanceQuestList.Qitems.IndexOf(item)].GetComponent<ListSlot>();
            questItem.AddAmount();
        }

        if (items.Count >= space)
        {
            Debug.Log("Not enough room.");
            return false;
        }
        items.Add(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }

    public void Remove (Item item)
    {
        items.Remove(item);

        if (QuestList.InstanceQuestList.Qitems.Contains(item))
        {
            questItem = QuestList.InstanceQuestList.slots[QuestList.InstanceQuestList.Qitems.IndexOf(item)].GetComponent<ListSlot>();
            questItem.removeAmount();
        }

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

    }
}
