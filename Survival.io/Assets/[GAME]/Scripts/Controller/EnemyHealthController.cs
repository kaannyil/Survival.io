using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour, IDamageable
{
    public static EnemyHealthController instance;

    public float maxHealth, currentHealth, recoil;
    [SerializeField] private int numberOfListCoin;

    [SerializeField] private GameObject coinObject;

    private void Awake()
    {
        instance = this;
    }

    public void Damage(float damage)
    {
        transform.position -= transform.forward * recoil;
        //BaseBulletSpawner.SharedInstance.SetEnemyHealth(currentHealth);
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Vector3 coinPos = new Vector3(transform.position.x, coinObject.transform.position.y, transform.position.z);
            CoinSpawner.SharedInstance.GetSmallCoin(coinPos, numberOfListCoin);

            gameObject.SetActive(false);

            ResetHealth();
        }
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
