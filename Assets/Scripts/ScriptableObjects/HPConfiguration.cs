using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomHealthConfiguration", menuName = "Configurations/HealthConfiguration")]
public class HPConfiguration : ScriptableObject
{
    [SerializeField]
    private int maxHelath = 100;
    [SerializeField]
    private int heal = 10;
    [SerializeField]
    private int damage = 10;
    private int _health = 100;
    public int health => _health;
    public void ResetHealth()
    {
        _health = maxHelath;
    }
    public int TakeDamage()
    {
        return UpdateHealth(-damage);
    }

    public int GetHeal()
    {
        return UpdateHealth(heal);
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    private int UpdateHealth(int deltaHealth)
    {
        return _health = Mathf.Clamp(health + deltaHealth, 0, maxHelath);
    }
}
