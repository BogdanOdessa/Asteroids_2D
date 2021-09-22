using UnityEngine;

namespace Asteroids2D
{
    public class EnemyCasualMove : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        private float Speed = 100f;
        private float xMovementHardcoded = -1f;
        private float yMovementHardcoded = 1f;
        
        public EnemyCasualMove(Rigidbody2D rigidbody2D)
        {
            _rigidbody2D = rigidbody2D;
        }
        public void Move()
        {
            var deltaTime = Time.deltaTime;
            var speed = deltaTime * Speed;
            _rigidbody2D.velocity = new Vector2(xMovementHardcoded, yMovementHardcoded) * speed;
        }
    }
}