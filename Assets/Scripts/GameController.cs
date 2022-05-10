using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    HPConfiguration hpConfig;
    [SerializeField]
    CoinsConfiguration coinsConfig;


    void OnEnable()
    {
        hpConfig.ResetHealth();
        coinsConfig.ResetCoins();
    }
}
