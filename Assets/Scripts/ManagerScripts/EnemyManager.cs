using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        WinScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            WinGameYippee();
        }
    }

    void WinGameYippee()
    {
        WinScreen.SetActive(true);
    }
}
