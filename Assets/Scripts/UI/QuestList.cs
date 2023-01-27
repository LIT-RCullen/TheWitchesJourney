using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestList : MonoBehaviour
{
    public List<Item> Qitems = new List<Item>();
    public List<float> amounts = new List<float>();

    public Transform listParent;

    public ListSlot[] slots;

    public static QuestList InstanceQuestList;

    void Awake()
    {
        if ((Qitems.Count > 3) || (amounts.Count > 3))
        {
            Debug.LogWarning("Too many quest items! Maximum count = 3.");
        }
        if (InstanceQuestList != null)
        {
            Debug.LogWarning("More than one instance of QuestList found!");
            return;
        }

        InstanceQuestList = this;
    }

    void Start()
    {
        slots = listParent.GetComponentsInChildren<ListSlot>();
        UpdateUI();
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < Qitems.Count)
            {
                slots[i].AddItem(Qitems[i], amounts[i]);
            }
        }
    }
}
