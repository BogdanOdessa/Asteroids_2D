using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

public class square : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        ViewServices.Destroy(other.gameObject);
        Destroy(other.gameObject);
    }
}
