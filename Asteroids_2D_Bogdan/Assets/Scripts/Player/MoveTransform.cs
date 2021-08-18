using UnityEngine;

namespace Asteroids2D
{
    internal class MoveTransform : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        private readonly Transform _transform;
        private Vector3 _move;
        
        public float Speed { get; protected set; }

        protected MoveTransform(Rigidbody2D rigidbody2D, Transform transform, float speed)
        {
            _rigidbody2D = rigidbody2D;
            _transform = transform;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical)
        {
            var deltaTime = Time.deltaTime;
            var speed = deltaTime * Speed;
            _rigidbody2D.velocity = new Vector2(horizontal, vertical) * speed;
            
            //_rigidbody2D.AddForce(new Vector2(horizontal,vertical)*speed, ForceMode2D.Force);
            //_move.Set(horizontal * speed, vertical * speed,0.0f);
            //_transform.localPosition += _move;
        }

      
    }
}


