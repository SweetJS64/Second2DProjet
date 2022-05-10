using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    [Header("Coins UI")]
    [SerializeField]
    private TMP_Text coinsText;
    private int coins = 0;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Coin")
        {            
            coins++;
            coinsText.text = coins.ToString();
            Destroy(coll.gameObject);
        }
    }
}
