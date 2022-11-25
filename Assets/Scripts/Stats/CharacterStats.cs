using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float maxHealth = 5;
    public float currentHealth { get; private set; }

    public Stat damage;
    
    void Awake ()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void HealDamage (int healing)
    {
        if (currentHealth == maxHealth)
        {
            //no way!
        }
        else if (currentHealth < maxHealth)
        {
            currentHealth += healing;

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
