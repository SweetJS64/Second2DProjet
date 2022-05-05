using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int MaxHelath = 100;
    public TMP_Text hpText;

    private void Update()
    {
        hpText.text = health.ToString();
    }
    public void TakeHit(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        
    }
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > MaxHelath)
        {
            health = MaxHelath;
        }
    }


}
