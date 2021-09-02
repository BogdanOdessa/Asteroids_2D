using System;
using UnityEngine.Serialization;

namespace Asteroids2D
{
    [Serializable]internal sealed class Hp
    {
         public float maxHp;
         public float currentHp;

        public override string ToString()
        {
            return $"MaxHP {maxHp} CurrentHP {currentHp}";
        }
    }
}