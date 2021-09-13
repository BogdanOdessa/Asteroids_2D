using UnityEngine;

namespace Asteroids2D
{
    public class TransformRandom
    {
        private Transform _transform;

        public TransformRandom(Transform transform)
        {
            _transform = transform;
        }

        public Vector3 GenerateRandomPosition()
        {
            var transformPosition = _transform.position;
            transformPosition.x = Random.Range(-150,150);
            transformPosition.y = Random.Range(0, 300);

            return transformPosition;
        }
    }
}