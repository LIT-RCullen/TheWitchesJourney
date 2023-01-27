using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public List<Item> inventory = new List<Item>();

    public GameData()
    {
        inventory = null;
    }
}
