using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TMP_Text))]
public class CoinsUI : MonoBehaviour
{
    private TMP_Text coinsText;
    private void OnEnable()
    {
        coinsText = gameObject.GetComponent<TMP_Text>();
    }
    public void UpdateCoins(int arg)
    {
        coinsText.text = arg.ToString();
    }
}
