using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Asteroids2D
{
    public class AsteroidMoving : Enemy
    {
        [SerializeField]private float _accelerationTime = 2f;
        [SerializeField]private float _maxSpeed = 5f;
        
        private Vector2 _movement;
        private float _timeLeft;
        private Rigidbody2D _rb;
        
        private const float MINRandomRange = -1f;
        private const float MAXRandomRange = 1f;
        
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void RandomMovement()
        {
            _timeLeft -= Time.deltaTime;
           
            if(_timeLeft <= 0)
            {
                var calculateRandomRange = Random.Range(MINRandomRange, MAXRandomRange);
                _movement = new Vector2(calculateRandomRange, calculateRandomRange);
                _timeLeft += _accelerationTime;
            }
        }

        public void AddForce()
        {
            _rb.AddForce(_movement * _maxSpeed);
        }

    }   
}

