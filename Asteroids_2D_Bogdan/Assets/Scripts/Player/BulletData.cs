using TMPro;
using UnityEngine;

namespace Asteroids2D
{
    public class BulletData
    {
        public float Damage { get; private set; } = 50f;
        public Color Color { get; private set; } = Color.black;
        

        public void AddDamage(int damage)
        {
            Damage += damage;
        }

        public void ChangeColor(Color color)
        {
            Color = color;
        }
    }
}