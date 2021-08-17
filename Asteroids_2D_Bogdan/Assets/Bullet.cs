using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyBullet", 5f);
    }
    private void DestroyBullet()
    {
        ViewServices.Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Asteroid"))
        {
            DestroyBullet();
        }
        
    }
}

