using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] protected UnityEvent _destroyFeedback;
    [SerializeField] protected EntityHealth _health;
    [SerializeField] protected   HealthUI _healthUI;

    public virtual void Use(PickUpItem pui)
    {

        // consume bag

        _destroyFeedback?.Invoke();
        Destroy(gameObject, 2f);
    }

}
