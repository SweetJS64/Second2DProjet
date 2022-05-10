using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomCoinsConfiguration", menuName = "Configurations/CoinsConfiguration")]
public class CoinsConfiguration : ScriptableObject
{
    private int _coins;
    public int coins => _coins;
    public void ResetCoins()
    {
        _coins = 0;
    }

    public void AddCoin()
    {
        _coins++;
    }
}
