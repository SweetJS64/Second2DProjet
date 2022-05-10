using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TMP_Text))]
public class CoinsUI : MonoBehaviour
{
    [SerializeField]
    private CoinsConfiguration coinsConfiguration;
    private TMP_Text coinsText;
    private void Start()
    {
        coinsText = gameObject.GetComponent<TMP_Text>();
        UpdateCoins();
    }
    public void UpdateCoins()
    {
        coinsText.text = coinsConfiguration.coins.ToString();
    }
}
