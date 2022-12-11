using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Slider slider;

    public PlayerStats Health;

    void Awake()
    {
        slider.maxValue = Health.maxHealth;
    }

    void Update()
    {
        SetHealth(Health.currentHealth);

    }

    public void SetHealth(float health)
    {
        slider.value = health;

    }
    
}
