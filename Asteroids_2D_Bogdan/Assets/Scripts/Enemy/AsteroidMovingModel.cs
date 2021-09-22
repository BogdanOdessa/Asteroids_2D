using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Asteroids2D
{
    [Serializable]
    public class AsteroidMovingModel
    {
        public readonly float accelerationTime = 2f;
        public readonly float maxSpeed = 5f;
        public const float MINRandomRange = -1f;
        public const float MAXRandomRange = 1f;
        public readonly float timeLeft =0f;
        public float initialHp = 100f;
    }
}