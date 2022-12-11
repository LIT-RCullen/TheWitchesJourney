using UnityEngine;

[CreateAssetMenu(fileName = "New Potion", menuName = "Inventory/Potion")]
public class Potion : ScriptableObject
{
    new public string name = "New Potion";
    public Sprite icon = null;
    public GameObject inGameObj;
    public int Amount;
}
