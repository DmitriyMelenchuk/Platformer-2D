using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace PixelCrew
{
    public class ExitLevelComponent : MonoBehaviour
    {   
        [SerializeField] private string _sceneName;

        public void Exit()
        {
            SceneManager.LoadScene(_sceneName); 
        }
    }

}


