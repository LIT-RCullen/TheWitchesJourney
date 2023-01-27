using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionUI : MonoBehaviour
{
    public Potion potion1;
    public Potion potion2;

    public Image potionIcon1;
    public Image potionIcon2;

    private PotionAttacks potions;

    public Text potion1Text;
    public Text potion2Text;

    void Start()
    {
        potions = PlayerManager.InstancePlayer.player.GetComponent<PotionAttacks>();

        potionIcon1.sprite = potion1.icon;
        potionIcon2.sprite = potion2.icon;
        potionIcon1.enabled = true;
        potionIcon2.enabled = true;

        potion1Text.text = potion1.useAmount.ToString();
        potion2Text.text = potion2.useAmount.ToString();
    }

    public void potionSlot1()
    {
        if(potion1.useAmount > 0)
        {
            if (potion1.name == "Explosive Potion")
            {
                potions.ExplosivePotion();
            }
            else if (potion1.name == "Fire Potion")
            {
                potions.firePotion();
            }
            else if ((potion1.name == "Major Potion of Healing") || (potion1.name == "Minor Potion of Healing"))
            {
                PlayerManager.InstancePlayer.player.GetComponent<PlayerStats>().HealDamage(potion1.AmountDH);
            }

            potion1.useAmount -= 1;
            potion1Text.text = potion1.useAmount.ToString();
        }
    }

    public void potionSlot2()
    {
        if (potion2.useAmount > 0)
        {
            if (potion2.name == "Explosive Potion")
            {
                potions.ExplosivePotion();
            }
            else if (potion2.name == "Fire Potion")
            {
                potions.firePotion();
            }
            else if ((potion2.name == "Major Potion of Healing") || (potion2.name == "Minor Potion of Healing"))
            {
                PlayerManager.InstancePlayer.player.GetComponent<PlayerStats>().HealDamage(potion2.AmountDH);
            }

            potion2.useAmount -= 1;
            potion2Text.text = potion2.useAmount.ToString();
        }
    }
}
