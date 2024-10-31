using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : Item
{
[SerializeField] private int _damageAmount = 50;

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        
           

            StartCoroutine(DamagePlayer());

            
            
        }
    }

    private IEnumerator DamagePlayer()
    {
      
            _health.TakeDamage(_damageAmount);
            _healthUI.DeggaUI();
            yield return new WaitForSeconds(0f);
            Destroy(gameObject, 1f);
            
        
    }
}
