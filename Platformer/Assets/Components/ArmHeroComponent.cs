using PixelCrew.Creatures;
using UnityEngine;

namespace PixelCrew.Model
{
    public class ArmHeroComponent : MonoBehaviour
    {
        public void ArmHero(GameObject go)
        {
            var hero = go.GetComponent<Hero>();
            if(hero != null)
            {
                hero.ArmHero();
            }
        }
    }
}