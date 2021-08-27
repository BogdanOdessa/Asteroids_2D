using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids2D
{
   [Serializable] public abstract class Enemy : MonoBehaviour
    {
        
        public static AsteroidMovingController CreateAsteroidMovingController(AsteroidMovingModel asteroidMovingModel)
        {
            var enemy = Instantiate(Resources.Load<GameObject>("Enemy/AsteroidMoving"));
            var asteroidMovingView = enemy.GetComponent<AsteroidMovingView>();
            var asteroidMovingHp = new AsteroidMovingHp(asteroidMovingModel,asteroidMovingView);
            var asteroidMovingController = new AsteroidMovingController(asteroidMovingView, asteroidMovingModel, asteroidMovingHp);
            return asteroidMovingController;
        }
        
        public static AsteroidMovingController DeepCopyAsteroidMovingController(AsteroidMovingModel asteroidMovingModel)
        {
            var enemy = Instantiate(Resources.Load<GameObject>("Enemy/AsteroidMoving"));
            var asteroidMovingView = enemy.GetComponent<AsteroidMovingView>();
            
            var asteroidMovingModelNew = asteroidMovingModel.DeepCopy();
            asteroidMovingModelNew.initialHp = RandomHpGenerator.GenerateRandomNumber();
            
            var asteroidMovingHp = new AsteroidMovingHp(asteroidMovingModelNew,asteroidMovingView);
            var asteroidMovingController = new AsteroidMovingController(asteroidMovingView, 
                asteroidMovingModelNew, asteroidMovingHp);
            
            var randomPosition = new TransformRandom(enemy.transform);
            enemy.transform.position = randomPosition.GenerateRandomPosition();
            
            return asteroidMovingController;
        }
    }

}