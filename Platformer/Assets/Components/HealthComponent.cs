using PixelCrew.Model;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private UnityEvent _onDamage;
        [SerializeField] private UnityEvent _onDie;
        [SerializeField] private UnityEvent _onHeal;
        [SerializeField] private HealthChangeEvent _onChange;

        public void ModifyHealth(int healthtDealta)
        {
            _health += healthtDealta;
            _onChange?.Invoke(_health);
            
            if (healthtDealta < 0)
            {
                _onDamage?.Invoke();
            }

            if (healthtDealta > 0)
            {
                _onHeal?.Invoke();
            }

            if (_health <= 0)
            {
                _onDie?.Invoke();
            }

        }

#if UNITY_EDITOR
        [ContextMenu("Update Health")]

        private void UpdateMenu()
        {
            _onChange?.Invoke(_health);
        }

#endif
        public void SetHealth(int health)
        {
            _health = health;
        }

        [Serializable]
        public class HealthChangeEvent : UnityEvent<int>
        {

        }

    }
}

