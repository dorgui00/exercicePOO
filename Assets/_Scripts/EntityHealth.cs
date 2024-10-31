using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    [ShowNonSerializedField] int _curientLife;

    [SerializeField] UnityEvent _onDie;

    public int CurrentHealth
    {
        get { return _curientLife; }
        set
        {
            if (value < 0)
            {
                Debug.Log("nop");
                return;
            }
            _curientLife += value;
        }
    }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Debug.Log("les dega ne son pas bon");
            return;
        }
        _curientLife = Mathf.Clamp(_curientLife - damage, 0, _maxHealth);


        if (_curientLife <= 0)
        {
            Die();
        }
    }

    public void Rigene(int heile)
    {
        if (heile <= 0)
        {
            Debug.Log("les dega ne son pas bon");
            return;
        }
        _curientLife = Mathf.Clamp(_curientLife + heile, 0, _maxHealth);
        if ( _curientLife > 100)
        {
            _curientLife = 100;
        }
    }

    private void Die()
    {
        var c1 = StartCoroutine(DieRoutine());

        IEnumerator DieRoutine()
        {
            _onDie.Invoke();
            Debug.Log("dying");

            yield return new WaitForSeconds(2f);




            Destroy(gameObject);
        }

    }



}
