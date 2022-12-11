using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListSlot : MonoBehaviour
{
    public Image icon;
    public Text text;

    Item item;

    private float saveAmount;
    private float amountFound = 0;

    public void AddItem(Item newItem, float requiredAmount)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;

        saveAmount = requiredAmount;
        text.text = 0 + "/" + requiredAmount;
    }

    public void AddAmount()
    {
        amountFound += 1;
        text.text = amountFound + "/" + saveAmount;
    }

    public void removeAmount()
    {
        amountFound -= 1;
        text.text = amountFound + "/" + saveAmount;
    }
}
