using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider2D))]
public class PlayerDamageController : MonoBehaviour
{
    [SerializeField]
    private GameObject respawn;
    private int oldHealth;

    public void HealthUpdate(int arg)
    {
        if (oldHealth > arg)
        {
            transform.position = respawn.transform.position;
            if (arg == 0)
            {
                Destroy(gameObject);
            }
        }
        oldHealth = arg;
    }
}
