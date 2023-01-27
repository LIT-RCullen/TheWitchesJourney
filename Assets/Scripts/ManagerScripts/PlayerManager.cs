using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager InstancePlayer;

    void Awake ()
    {
        InstancePlayer = this;
    }

    public GameObject player;
}
