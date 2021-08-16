using System;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

namespace Asteroids2D
{
    internal sealed class PlayerInitialize : MonoBehaviour
    {
        public PlayerSettings playerSettings;
        public Ship ship;
        public PlayerShoot playerShoot;
        public PlayerHP playerHp;
        
        private float _hp;
        private Transform _barrelTransform;

        public void Start()
        {
            var moveTransform = new AccelerationMove(transform, playerSettings._speed, playerSettings._acceleration);
            var rotation = new RotationShip(transform);
            ship = new Ship(moveTransform, rotation);
            _barrelTransform = FindObjectOfType<PlayerView>().GetComponentInChildren<Transform>();
            playerShoot = new PlayerShoot(playerSettings._bullet, _barrelTransform, playerSettings._force);
            
            _hp = playerSettings._hp;
            playerHp = new PlayerHP(_hp);
        }
    }
}

