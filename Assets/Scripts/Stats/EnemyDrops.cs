using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    public List<GameObject> Drops = new List<GameObject>();

    public int MaxDropAmount = 3;

    float tempX;
    float tempZ;

    int dropAmount;
    GameObject holdItem;

    void Awake()
    {
        if (MaxDropAmount <= 0)
        {
            Debug.LogWarning("Maximum Drop Amount on" + transform.name + " too low!");
            return;
        }
    }

    public void DropItem()
    {
        dropAmount = Random.Range(1, MaxDropAmount);
        for (int i = 0; i < dropAmount; i++)
        {
            holdItem = Drops[Random.Range(0, Drops.Count)];

            tempX = Random.Range(-5, 5) + transform.position.x;
            tempZ = Random.Range(-5, 5) + transform.position.z;
            
            Instantiate(holdItem, new Vector3(tempX, 1.5f, tempZ), holdItem.transform.rotation);
        }   
    }
}
