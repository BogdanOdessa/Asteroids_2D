using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    [Serializable]internal sealed class PlayerData
    {
        public float Speed;
        public Hp Hp;

        public override string ToString()
        {
            return $"Speed {Speed} Hp {Hp}";
        }
    }
 
}

