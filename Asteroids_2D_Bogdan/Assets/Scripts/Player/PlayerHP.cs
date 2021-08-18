using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerHP
    {
        private float hp { get; set; }

        public PlayerHP(float hp)
        {
            this.hp = hp;
        }

        public void Collide(GameObject gameObject)
        {
            if (hp <= 0)
            {
                Object.Destroy(gameObject);
            }
            else
            {
                hp--;
            } 
        }
   
    } 
}

