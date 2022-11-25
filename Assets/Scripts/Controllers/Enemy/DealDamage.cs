using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public EnemyStats enemyAttack;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats playerHealth = collider.GetComponent<PlayerStats>();
            playerHealth.TakeDamage(enemyAttack.damage.GetValue());
        }
    }
}
