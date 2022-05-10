using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField]
    private GameEvent damageEvent;
    
    [SerializeField]
    private GameEvent respEvent;
    
    [SerializeField]
    private HPConfiguration healthConfiguration;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            healthConfiguration.TakeDamage();
            damageEvent.RaiseEvent();
            respEvent.RaiseEvent();
        }
    }
}
