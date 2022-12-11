using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public List<GameObject> keyEnemies = new List<GameObject>();

    void FixedUpdate()
    {

        if (keyEnemies[0] == null)
        {
            keyEnemies.RemoveAt(0);
        }


        if (keyEnemies.Count <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
