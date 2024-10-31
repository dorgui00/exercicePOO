using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }

    private void Start()
    {
        DeggaUI();
    }

    public void DeggaUI()
    {
        _slider.value = _playerHealth.CurrentHealth;
        _text.text = $"{_playerHealth.CurrentHealth} / {_playerHealth.MaxHealth}";
    }

}
