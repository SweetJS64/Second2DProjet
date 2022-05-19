using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Health : MonoBehaviour
{
    [Header("Health configuration")]
    [SerializeField]
    private int maxHelath = 100;
    [SerializeField]
    private int collisionHeal = 10;
    [SerializeField]
    private int collisionDamage = 10;
    

    [Header("Respawn point info")]
    [SerializeField]
    private GameObject respawn;

    [Header("Death Screen info")]
    [SerializeField]
    private GameObject deathScreen;

    [Header("Health UI")]
    [SerializeField]
    private TMP_Text hpText;

    private int health = 100;

    private void Start()
    {
        health = maxHelath;
    }

    private void Update()
    {
        hpText.text = health.ToString();
    }

    private void UpdateHealth(int bonusHealth)
    {
        var resultHealth = health + bonusHealth;

        if (resultHealth <= 0)
        {
            health = 0;
            deathScreen.SetActive(true);
            return;
        }
        else if (resultHealth >= maxHelath)
        {
            health = maxHelath;
        }
        else 
        {
            health = resultHealth;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Heal":
                UpdateHealth(collisionHeal);
                Destroy(other.gameObject);
                break;
            case "DeathZone":
                UpdateHealth(-collisionDamage);
                if (health != 0)
                {
                    transform.position = respawn.transform.position;
                }
                break;
        }
    }
}
