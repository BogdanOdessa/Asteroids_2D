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
        private float _maxPlayerHp = 100f;
        private readonly Transform _barrelTransform;
        private readonly float _shipSpeed;
        private readonly float _shipAcceleration;
        private readonly Rigidbody2D _bulletRb;
        private readonly float _bulletForce;
        private readonly Rigidbody2D _playerRigidBody;
        private readonly Transform _playerPosition;

        public PlayerInitialize(Transform playerPosition, Transform barrelTransform, 
            float shipSpeed, float shipAcceleration, Rigidbody2D bulletRb, float bulletForce, Rigidbody2D playerRigidBody)
        {
            _playerPosition = playerPosition;
            _barrelTransform = barrelTransform;
            _shipSpeed = shipSpeed;
            _shipAcceleration = shipAcceleration;
            _bulletRb = bulletRb;
            _bulletForce = bulletForce;
            _playerRigidBody = playerRigidBody;
        }
        public void InitializePlayer()
        {
            var moveTransform = new AccelerationPlayerMove(_playerRigidBody,_playerPosition, _shipSpeed, _shipAcceleration);
            var rotation = new RotationShip(_playerPosition);
            ship = new Ship(moveTransform, rotation);
            
            //_barrelTransform = FindObjectOfType<PlayerView>().GetComponentInChildren<Transform>();
            playerShoot = new PlayerShoot(_bulletRb, _barrelTransform, _bulletForce);

            _hp = _maxPlayerHp;
            //_hp = playerSettings._hp;
            playerHp = new PlayerHP(_hp);
        }
    }
}

