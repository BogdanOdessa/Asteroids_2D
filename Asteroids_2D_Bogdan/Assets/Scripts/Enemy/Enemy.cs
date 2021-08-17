using System;
using UnityEngine;

namespace Asteroids2D
{
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Health Health { get; protected set; }

        private void Awake()
        {
            Factory = new AsteroidFactory();
        }

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
        
            enemy.Health = hp;
        
            return enemy;
        }
    }

}