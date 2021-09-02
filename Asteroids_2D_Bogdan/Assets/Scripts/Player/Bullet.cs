using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

namespace Asteroids2D
{
    public class Bullet : MonoBehaviour
    {
        public const float Damage = 50f;

        private void Start()
        {
            Invoke(nameof(DestroyBullet), 5f);
        }
        private void DestroyBullet()
        {
            ViewServices.Destroy(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.GetComponent<Enemy>())
            {
                DestroyBullet();
            
            }
        
        }
    } 
}


