using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Debug.Log("Picked up item.");
        bool wasPickedUp = Inventory.InstanceInventory.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
