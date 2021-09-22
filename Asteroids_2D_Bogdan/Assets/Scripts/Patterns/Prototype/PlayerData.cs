using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Asteroids2D
{
    [Serializable]internal sealed class PlayerData
    {
         public float speed;
         public Hp hp;

        public override string ToString()
        {
            return $"Speed {speed} Hp {hp}";
        }
    }
 
}

