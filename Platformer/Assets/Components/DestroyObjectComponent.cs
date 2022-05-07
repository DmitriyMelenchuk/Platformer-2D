using UnityEngine;

namespace PixelCrew.Components
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] GameObject _objectDestroy;
        

        public void OnDestroyObject() 
        {
            Destroy(_objectDestroy);
            
        }
    }

}

