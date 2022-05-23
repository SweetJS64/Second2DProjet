using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CoinPicker : MonoBehaviour
{
    [Header("Coins UI")]
    [SerializeField]
    private TMP_Text coinsText;
    [SerializeField]
    private TMP_Text recordCoinsText;
    private int coins = 0;
    private int recordCoins;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Coin")
        {            
            coins++;
            coinsText.text = coins.ToString();
            Destroy(coll.gameObject);
        }
    }
    private void Update()
    {
        if (coins > recordCoins)
        {
            PlayerPrefs.SetInt("recordCoins", coins);
        }

        recordCoins = PlayerPrefs.GetInt("recordCoins");
        recordCoinsText.text = "HIGHSCORE: " + recordCoins.ToString();

        if (coins == 40)
        {
            SceneManager.LoadScene(3);
        }
    }
}
