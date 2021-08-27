using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Asteroids2D
{
    public sealed class Asteroid : Enemy
    {
        private EnemyData EnemyData;
        public float hp;

        private void Start()
        {
            gameObject.name = EnemyData.AsteroidName;
        }

    }

}