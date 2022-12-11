using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;

    public List<Item> items = new List<Item>();
 
    ListSlot questItem;

    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }



    public bool Add (Item item)
    {
        if (QuestList.instance.Qitems.Contains(item))
        {
            questItem = QuestList.instance.slots[QuestList.instance.Qitems.IndexOf(item)].GetComponent<ListSlot>();
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

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
