using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody rb;

    public int Damage;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.tag != "Enemy")
        {
            Debug.Log("Colliding with" + collider.name);
            if (collider.tag == "Player")
            {
                PlayerStats playerHealth = collider.GetComponent<PlayerStats>();
                playerHealth.TakeDamage(Damage);
            }
            //cool animation
            Destroy(gameObject);
        }
        
    }
}
