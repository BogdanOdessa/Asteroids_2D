using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP
{
    public float hp { get; private set; }

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
