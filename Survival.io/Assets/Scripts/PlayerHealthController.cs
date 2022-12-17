using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public float maxHealth, currentHealth;
    [SerializeField] private HealthBar healthBar;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ResetHealth();
    }

    private void Update()
    {
        healthBar.updateHealthBar(maxHealth, currentHealth);
        
        if (currentHealth <= 0)
        {

        }
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
