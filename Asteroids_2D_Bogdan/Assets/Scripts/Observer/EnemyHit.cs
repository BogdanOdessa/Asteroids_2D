using System;
using UnityEngine;

namespace Asteroids2D
{
    public class EnemyHit: IHit
    {
        public event Action<string> OnHitChange = delegate(string s) {  };
        public void Hit(string name)
        {
           Debug.Log(name);
        }
    }
}