using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour
{
    [Header("Coins UI")] [SerializeField] private TMP_Text coinsText;
    [SerializeField] private TMP_Text recordCoinsText;
    private int _coins;
    private int _recordCoins;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Coin"))
        {
            _coins++;
            coinsText.text = _coins.ToString();
            Destroy(coll.gameObject);
        }
    }

    private void Update()
    {
        if (_coins > _recordCoins)
        {
            PlayerPrefs.SetInt("recordCoins", _coins);
        }

        _recordCoins = PlayerPrefs.GetInt("recordCoins");
        recordCoinsText.text = "HIGH SCORE: " + _recordCoins;

        if (_coins == 40)
        {
            SceneManager.LoadScene(3);
        }
    }
}