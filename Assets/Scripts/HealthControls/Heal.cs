using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField]
    private IntEvent healthEvent;
    [SerializeField]
    private HPConfiguration healthConfiguration;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            healthConfiguration.GetHeal();
            healthEvent.RaiseEvent(healthConfiguration.health);
        }
    }
}
