using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerView : MonoBehaviour
    {
        private Camera _camera;
        private Ship _ship;
        private PlayerInitialize _player;
        private PlayerShoot _playerShoot;
        private PlayerHP _playerHp;
        
        private void Start()
        {
            _player = FindObjectOfType<GameStarter>()._playerInitialize;
            _camera = Camera.main;
            _ship = _player.ship;
            _playerShoot = _player.playerShoot;
            _playerHp = _player.playerHp;
        }

        public void Rotate()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
        }

        public void Move()
        {
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        public void Accelerate()
        {
            _ship.AddAcceleration();
        }

        public void DeAccelerate()
        {
            _ship.RemoveAcceleration();
        }

        public void Shoot()
        {
            _playerShoot.Shoot();
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            _playerHp.Collide(gameObject);
        }
        
    } 
}

