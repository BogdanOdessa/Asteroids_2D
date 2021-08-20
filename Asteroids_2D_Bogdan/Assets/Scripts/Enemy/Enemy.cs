using System;
using UnityEngine;

namespace Asteroids2D
{
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Health Health { get; protected set; }
        public float hp;

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
        
        public static AsteroidMoving CreateAsteroidMovingEnemy(float hp)
        {
            var enemy = Instantiate(Resources.Load<AsteroidMoving>("Enemy/AsteroidMoving"));
        
            enemy.hp = hp;
        
            return enemy;
        }
    }

}