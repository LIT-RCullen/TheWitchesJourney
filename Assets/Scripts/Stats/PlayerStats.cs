using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    private GameManager deathScreen;

    void Start()
    {
        deathScreen = GameManager.instance;
    }

    public override void Die()
    {
        deathScreen.killPlayer();
        Destroy(gameObject);
    }
}
