using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TMP_Text))]
public class HealthUI : MonoBehaviour
{
    [SerializeField]
    private HPConfiguration healthConfiguration;
    private TMP_Text hpText;
    private void Start()
    {
        hpText = gameObject.GetComponent<TMP_Text>();
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        hpText.text = healthConfiguration.health.ToString();
    }
}
