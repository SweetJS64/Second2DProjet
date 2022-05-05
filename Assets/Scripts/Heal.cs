using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int collisionHeal = 10;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Health health = other.gameObject.GetComponent<Health>();
            health.SetHealth(collisionHeal);
            Destroy(gameObject);    

        }
    }
}
