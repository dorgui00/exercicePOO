using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPotion : Item
{
   
    [SerializeField] int _PVposion = 50;
    
    public override void Use(PickUpItem pui)
    {
        base.Use(pui);

            _health.Rigene(_PVposion);
            _healthUI.DeggaUI();
            Debug.Log("dying");


    }

    

}
