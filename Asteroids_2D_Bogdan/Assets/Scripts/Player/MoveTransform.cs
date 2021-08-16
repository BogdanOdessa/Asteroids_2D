using UnityEngine;

namespace Asteroids2D
{
    internal class MoveTransform : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;
        
        public float Speed { get; protected set; }

        protected MoveTransform(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical)
        {
            var deltaTime = Time.deltaTime;
            var speed = deltaTime * Speed;
            _move.Set(horizontal * speed, vertical * speed,0.0f);
            _transform.localPosition += _move;
        }

      
    }
}


