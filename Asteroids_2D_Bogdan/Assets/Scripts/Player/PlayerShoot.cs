using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerShoot : IGun
    {
        private Rigidbody2D _bullet;
        private Transform _barrel;
        private float _force;
        
        public PlayerShoot(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }
        public void Shoot()
        {
            var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }

}
