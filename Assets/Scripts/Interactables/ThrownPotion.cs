using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownPotion : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody rb;

    public Potion Damage;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    void OnTriggerEnter (Collider collider)
    {
        if ((collider.tag != "Player"))
        {
            Debug.Log("Colliding with" + collider.name);
            if (collider.tag == "Enemy")
            {
                EnemyStats enemyHealth = collider.GetComponent<EnemyStats>();
                enemyHealth.TakeDamage(Damage.AmountDH);
            }
            //cool animation
            Destroy(gameObject);
        }
        
    }
}
