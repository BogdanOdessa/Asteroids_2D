using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class FacadeCreateEnemies 
    {
        
        internal List<AsteroidMovingController> CreateEnemiesWithController(float enemiesAmount)
        {
            var asteroidMovingControllers = new List<AsteroidMovingController>();
            var asteroidMovingModel = new AsteroidMovingModel();
            asteroidMovingControllers.Add(Enemy.CreateAsteroidMovingController(asteroidMovingModel));
            
            for (var i = 0; i < enemiesAmount; i++)
            {
                asteroidMovingControllers.Add(Enemy.DeepCopyAsteroidMovingController(asteroidMovingModel));
            }

            return asteroidMovingControllers;
        }
    }
}

