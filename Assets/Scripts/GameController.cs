using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private HPConfiguration hpConfig;
    [SerializeField]
    private CoinsConfiguration coinsConfig;
    [SerializeField]
    private IntEvent healthUpdate;
    [SerializeField]
    private IntEvent coinsUpdate;

    void OnEnable()
    {
        hpConfig.ResetHealth();
        coinsConfig.ResetCoins();
    }

    private void Start()
    {
        healthUpdate.RaiseEvent(hpConfig.health);
        coinsUpdate.RaiseEvent(coinsConfig.coins);
    }
}
