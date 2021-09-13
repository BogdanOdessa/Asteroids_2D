using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class BulletComposedData
    {
        public float Damage { get;}
        public Color Color { get;}
        
        public BulletComposedData()
        {
            var bulletData = new BulletData();
            var root = new BulletModifer(bulletData);
            root.Add(new AddAttack(bulletData, 10));
            root.Add(new AddColor(bulletData, Color.cyan));
            root.Handle();
            Damage = bulletData.Damage;
            Color = bulletData.Color;
        }
    } 
    
   
}

