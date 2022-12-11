using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamPos : MonoBehaviour
{
    public GameObject Place1;
    public GameObject Place2;
    public GameObject Camera;

    private bool isPlace1 = true;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (isPlace1)
            {
                Camera.transform.position = Place2.transform.position;
                isPlace1 = false;
            }
            else if (!isPlace1)
            {
                Camera.transform.position = Place1.transform.position;
                isPlace1 = true;
            }
        }
    }
}
