using System;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace Asteroids2D
{
    public class AsteroidMovingHp: IHit
    {
        public event Action<string> OnHitChange = delegate(string f) { };
        private readonly AsteroidMovingView _asteroidMovingView;
        private float _hp;

        public AsteroidMovingHp(AsteroidMovingModel asteroidMovingModel, AsteroidMovingView asteroidMovingView)
        {
            _asteroidMovingView = asteroidMovingView;
            _hp = asteroidMovingModel.initialHp;
            asteroidMovingView.hp = _hp;
        }
        
        public void TakeDamage(float damage, string name)
        {
            _hp -= damage;
            if (_hp <= 0)
            { _asteroidMovingView.Die();
               OnHitChange.Invoke(name);
            }
        }
        
        
        public void Hit(string name)
        {
            Debug.Log(name);
        }
    }
}