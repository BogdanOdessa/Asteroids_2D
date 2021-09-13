using UnityEngine;

namespace Asteroids2D
{
    internal sealed class AccelerationPlayerMove : PlayerMoveTransform
    {
        private readonly float _acceleration;

        public AccelerationPlayerMove(Rigidbody2D rigidbody2D, Transform transform, float speed, float acceleration) 
            : base(rigidbody2D, transform, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        } 
    }
}