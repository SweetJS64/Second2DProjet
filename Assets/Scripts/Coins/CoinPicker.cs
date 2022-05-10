using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    [SerializeField]
    private CoinsConfiguration coinsConfiguration;
    [SerializeField]
    private GameEvent coinCollected;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            coinsConfiguration.AddCoin();
            Destroy(gameObject);
            coinCollected.RaiseEvent();
        }
    }
}
