using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

namespace Asteroids2D
{
    public class Bullet : MonoBehaviour
    {
        public float Damage { get; private set; }
        private SpriteRenderer _spriteRenderer;

        private BulletComposedData _bulletComposedData;
        
        private void Start()
        {
            _bulletComposedData = new BulletComposedData();
            Damage = _bulletComposedData.Damage;
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.material.color = _bulletComposedData.Color;
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


