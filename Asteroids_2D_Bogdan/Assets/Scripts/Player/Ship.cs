using UnityEngine;

namespace Asteroids2D
{
    internal sealed class Ship : IPlayerMove, IRotation
    {
        private readonly IPlayerMove _playerMoveImplementation;
        private readonly IRotation _rotationImplementation;
       private Context _context;

        public float Speed => _playerMoveImplementation.Speed;

        public Ship(IPlayerMove playerMoveImplementation, IRotation rotationImplementation)
        {
            _playerMoveImplementation = playerMoveImplementation;
            _rotationImplementation = rotationImplementation;
            _context = new Context(new FirsStateMovingSlow());
        }

        public void Move(float horizontal, float vertical)
        {
            _playerMoveImplementation.Move(horizontal, vertical);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (_playerMoveImplementation is AccelerationPlayerMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
                _context.ChangeState();
            }
        }

        public void RemoveAcceleration()
        {
            if (_playerMoveImplementation is AccelerationPlayerMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
                _context.ChangeState();
            }
        }
    }
}