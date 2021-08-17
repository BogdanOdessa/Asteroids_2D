using System;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace Asteroids2D
{
    internal sealed class PlayerInitialize
    {
        public Ship ship;
        public PlayerShoot playerShoot;
        public PlayerHP playerHp;
        
        private float _hp;
        private Transform _barrelTransform;
        private  float _shipSpeed;
        private  float _shipAcceleration;
        private  Rigidbody2D _bulletRb;
        private  float _bulletForce;
        private Transform _playerPosition;

        public PlayerInitialize(Transform playerPosition, Transform barrelTransform, 
            float shipSpeed, float shipAcceleration, Rigidbody2D bulletRb, float bulletForce)
        {
            _playerPosition = playerPosition;
            _barrelTransform = barrelTransform;
            _shipSpeed = shipSpeed;
            _shipAcceleration = shipAcceleration;
            _bulletRb = bulletRb;
            _bulletForce = bulletForce;
        }
        public void Init()
        {
            var moveTransform = new AccelerationMove(_playerPosition, _shipSpeed, _shipAcceleration);
            var rotation = new RotationShip(_playerPosition);
            ship = new Ship(moveTransform, rotation);
            
            //_barrelTransform = FindObjectOfType<PlayerView>().GetComponentInChildren<Transform>();
            playerShoot = new PlayerShoot(_bulletRb, _barrelTransform, _bulletForce);

            _hp = 100f;
            //_hp = playerSettings._hp;
            playerHp = new PlayerHP(_hp);
        }
    }
}

