using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private EntityGold _entityGold;
    [SerializeField] private EntityHealth _entityHealth;
    [SerializeField] private HealthUI _healthUI;
    
    public EntityGold EntityGold => _entityGold;
    public EntityHealth PlayerHealth => _entityHealth;
    public HealthUI HitEntity => _healthUI;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            item.Use(this);
        }
    }



}
