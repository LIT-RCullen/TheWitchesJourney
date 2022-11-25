using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public EnemyDrops loot;

    public override void Die()
    {
        loot.DropItem();

        Destroy(gameObject);

        //cool death animation
    }
}
