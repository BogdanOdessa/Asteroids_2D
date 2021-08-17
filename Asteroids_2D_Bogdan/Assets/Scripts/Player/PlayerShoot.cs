using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEditor;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerShoot : IGun
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;
        private GameObject _prefab;
        
        
        public PlayerShoot(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
            _prefab = Resources.Load<GameObject>("Bullet");
        }
        // ReSharper disable Unity.PerformanceAnalysis
        public void Shoot()
        {
            //var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            //temAmmunition.AddForce(_barrel.up * _force);
            var rigidbody2D = ViewServices.Instantiate(_prefab).GetComponent<Rigidbody2D>();
            rigidbody2D.transform.position = _barrel.transform.position;
            rigidbody2D.AddForce(_barrel.up * _force);
        }
    }

}
