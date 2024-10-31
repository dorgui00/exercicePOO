using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPotion : Item
{
    [SerializeField] EntityHealth _health;
    [SerializeField] HealthUI _healthUI;
    [SerializeField] int _PVposion = 50;
    [SerializeField] UnityEvent _onDie;
    public override void Use(PickUpItem pui)
    {
        base.Use(pui);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _health.Rigene(_PVposion);
            _healthUI.DeggaUI();
            _onDie.Invoke();
            Debug.Log("dying");




            Destroy(gameObject);

        }
    }

}
