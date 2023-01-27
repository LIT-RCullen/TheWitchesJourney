using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;

    float tempX;
    float tempZ;

    Item item;

    PlayerManager playerPos;

    void Awake()
    {
        playerPos = PlayerManager.InstancePlayer;
    }

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        tempX = Random.Range(-5, 5) + playerPos.player.transform.position.x;
        tempZ = Random.Range(-5, 5) + playerPos.player.transform.position.z;

        Instantiate(item.inGameObj, new Vector3(tempX, 1.5f, tempZ), item.inGameObj.transform.rotation);
        Inventory.InstanceInventory.Remove(item);
    }
}
