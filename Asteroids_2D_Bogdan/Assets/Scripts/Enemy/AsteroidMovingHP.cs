using UnityEngine;

namespace Asteroids2D
{
    public class AsteroidMovingHp
    {
        private readonly AsteroidMovingView _asteroidMovingView;
        public float _hp;

        public AsteroidMovingHp(AsteroidMovingModel asteroidMovingModel, AsteroidMovingView asteroidMovingView)
        {
            _asteroidMovingView = asteroidMovingView;
            _hp = asteroidMovingModel.initialHp;
            asteroidMovingView.hp = _hp;
        }
        
        public void TakeDamage(float damage)
        {
            _hp -= damage;
            if (_hp <= 0) _asteroidMovingView.Die();
        }

    }
}