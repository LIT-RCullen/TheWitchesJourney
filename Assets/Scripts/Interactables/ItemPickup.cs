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
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        { 
            Destroy(gameObject); 
        }
    }
}
