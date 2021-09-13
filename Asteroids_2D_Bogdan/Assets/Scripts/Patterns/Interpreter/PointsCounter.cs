using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PointsCounter 
    {
        public int PointsAmount { get; private set; }
        public int DestroyedAsteroidsAmount { get; private set; }

        private const int PointsForOneAsteroid = 500;
        private const int OneDestroyedAsteroid = 1;

        public void ReceivePoints()
        {
            PointsAmount += PointsForOneAsteroid;
            DestroyedAsteroidsAmount += OneDestroyedAsteroid;
        }
    }
}
