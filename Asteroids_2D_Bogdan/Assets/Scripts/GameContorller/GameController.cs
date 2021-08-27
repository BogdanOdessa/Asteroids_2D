using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class GameController : MonoBehaviour
    {
        private PlayerController _playerController;
        private PlayerView _playerView;
        
        private  List<AsteroidMovingController> _asteroidMovingControllers = new List<AsteroidMovingController>();
        private AsteroidMovingModel _asteroidMovingModel;
        private int enemyAmount = 100;

        private void Start()
        {
            _playerView = FindObjectOfType<PlayerView>();
            _playerController = new PlayerController(_playerView);
            
            
            _asteroidMovingModel = new AsteroidMovingModel();
            _asteroidMovingControllers.Add(Enemy.CreateAsteroidMovingController(_asteroidMovingModel));
            
            for (var i = 0; i < enemyAmount; i++)
            {
                _asteroidMovingControllers.Add(Enemy.DeepCopyAsteroidMovingController(_asteroidMovingModel));
            }

        }

        private void Update()
        {
            _playerController.UpdateExecute();

            foreach (var t in _asteroidMovingControllers)
            {
                t.UpdateExecute();
            }
        }

        private void FixedUpdate()
        {
            _playerController.FixedUpdateExecute();
            
            
            foreach (var t in _asteroidMovingControllers)
            {
                t.FixedUpdateExecute();
            }
        }
        
    }  
}

