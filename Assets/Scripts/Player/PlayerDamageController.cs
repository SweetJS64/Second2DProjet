using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider2D))]
public class PlayerDamageController : MonoBehaviour
{
    [Header("Health configuration")]
    [SerializeField]
    private HPConfiguration healthConfiguration;

    [Header("Respawn point info")]
    [SerializeField]
    private GameObject respawn;

    public void HealthUpdate()
    {
        if (healthConfiguration.IsDead())
        {
            Destroy(gameObject);
        }
    }

    public void Respawn()
    {
        transform.position = respawn.transform.position;
    }
}
