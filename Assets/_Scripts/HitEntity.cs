using System.Collections;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private EntityHealth _health;
    [SerializeField] private int damageAmount = 10;
    [SerializeField] private float damageInterval = 1f;

    [SerializeField] private HealthUI _healthUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur est entr� dans la zone");
            StartCoroutine(DamagePlayer());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur est sorti de la zone");
            StopAllCoroutines(); 
        }
    }

    private IEnumerator DamagePlayer()
    {
        while(true)
        {
             _health.TakeDamage(damageAmount);
            _healthUI.DeggaUI();
            Debug.Log(_health.CurrentHealth);
            yield return new WaitForSeconds(2f);
        }
            
        
    }
}
