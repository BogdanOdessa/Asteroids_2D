using UnityEngine;

namespace Asteroids2D
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public Enemy Create(float hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));

           // enemy.hp = hp;
        
            return enemy;
        }
    }
}