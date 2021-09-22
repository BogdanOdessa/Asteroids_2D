

using UnityEngine;

namespace Asteroids2D
{
    public static class RandomHpGenerator
    {
        private const float MINHp = 1f;
        private const float MAXHp = 200f;
        
        public static float GenerateRandomNumber()
        {
            return Mathf.Round(Random.Range(MINHp, MAXHp));
        }
    }
}