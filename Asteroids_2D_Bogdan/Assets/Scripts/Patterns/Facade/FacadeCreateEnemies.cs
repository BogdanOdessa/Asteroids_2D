using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class FacadeCreateEnemies 
    {
        
        internal List<AsteroidMovingController> CreateEnemiesWithController(float enemiesAmount, PointsCounter pointsCounterClass)
        {
            var listenerHitShowName = new ListenerHitShowName();

            var asteroidMovingControllers = new List<AsteroidMovingController>();
            var asteroidMovingModel = new AsteroidMovingModel();
            var points = pointsCounterClass;
           
            asteroidMovingControllers.Add(Enemy.CreateAsteroidMovingController(asteroidMovingModel, points));
            
            for (var i = 0; i < enemiesAmount; i++)
            {
                asteroidMovingControllers.Add(Enemy.DeepCopyAsteroidMovingController(asteroidMovingModel, points));
                listenerHitShowName.Add(asteroidMovingControllers[i]._asteroidMovingHp);
            }

            return asteroidMovingControllers;
        }
    }
}

