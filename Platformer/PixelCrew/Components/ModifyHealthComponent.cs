using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components
{

    public class ModifyHealthComponent : MonoBehaviour
    {
        [SerializeField] private int _hpDealta;

        public void Apply(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();
            if (healthComponent != null)
            {
                healthComponent.ModifyHealth(_hpDealta);

                

            }
        }
    }
}
