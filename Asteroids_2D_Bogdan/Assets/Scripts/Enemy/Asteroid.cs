using System;

namespace Asteroids2D
{
    public sealed class Asteroid : Enemy
    {
        public float maxhealth;
        public float currenthealth;
        
        public Health Health;

        private void Start()
        {
            currenthealth = Health.Current;
            maxhealth = Health.Max;
        }
    }
}