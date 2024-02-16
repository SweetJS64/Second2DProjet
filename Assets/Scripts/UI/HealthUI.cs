using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TMP_Text))]
public class HealthUI : MonoBehaviour
{
    private TMP_Text hpText;
    private void OnEnable()
    {
        hpText = gameObject.GetComponent<TMP_Text>();
    }
    public void UpdateHealth(int arg)
    {
        hpText.text = arg.ToString();
    }
}
