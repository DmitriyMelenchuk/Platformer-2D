using System;
using UnityEngine;
using System.Collections;
using PixelCrew.Components;


namespace PixelCrew.Creatures
{
    public abstract class Patrol : MonoBehaviour
    {
        public abstract IEnumerator DoPatrol();          
    }
}


