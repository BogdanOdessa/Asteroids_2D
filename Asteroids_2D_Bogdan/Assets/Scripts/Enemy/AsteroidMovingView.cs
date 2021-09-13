using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Asteroids2D
{
    public class AsteroidMovingView : Enemy
    {
/*[SerializeField]private float _accelerationTime = 2f;
[SerializeField]private float _maxSpeed = 5f;
private float _timeLeft;
private const float MINRandomRange = -1f;
private const float MAXRandomRange = 1f;
*/
        private Vector2 _movement;
        private Rigidbody2D _rb;
        private float _timeLeft;
        private AsteroidMovingController _asteroidMovingController;
        public float hp; //just to check

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            gameObject.name = EnemyData.AsteroidMovingName;
        }

        public void RandomMovement(float minRandomRange, float maxRandomRange, float accelerationTime)
        {
            _timeLeft -= Time.deltaTime;
            if(_timeLeft <= 0)
            {
                var calculateRandomRange = Random.Range(minRandomRange, maxRandomRange);
                _movement = new Vector2(calculateRandomRange, calculateRandomRange);
                _timeLeft += accelerationTime;
            }
        }

        public void AddForce(float maxSpeed)
        {
            if (this == null) return;
            _rb?.AddForce(_movement * maxSpeed);
        }

        public void Die()
        {
            Destroy(gameObject);
            _asteroidMovingController.GetPointsAmount();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _asteroidMovingController.Collision(other);
        }
        

        public void GetController(AsteroidMovingController asteroidMovingController)
        {
            _asteroidMovingController = asteroidMovingController;
        }
    }   
}

