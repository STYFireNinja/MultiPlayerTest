using System;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    [SerializeField] private Text amountOfHealth;

    private void Update()
    {
        if (amountOfHealth != null)
        {
            amountOfHealth.text = $"Health: {health}";
        }      
    }
    public void TakeDamage(float amountOfDamage)
    {
        health -= amountOfDamage;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
