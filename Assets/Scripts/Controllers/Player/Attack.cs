using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public PlayerStats playerAttack;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy")
        {
            EnemyStats enemyHealth = collider.GetComponent<EnemyStats>();
            enemyHealth.TakeDamage(playerAttack.damage.GetValue());
        }
    }
}
