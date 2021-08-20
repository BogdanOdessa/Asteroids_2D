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

        private AsteroidMovingController _asteroidMovingController;
        private AsteroidMoving _asteroidMoving;
        
        private void Start()
        {
            _playerView = FindObjectOfType<PlayerView>();
            _playerController = new PlayerController(_playerView);
            
            _asteroidMoving = FindObjectOfType<AsteroidMoving>();
            _asteroidMovingController = new AsteroidMovingController(_asteroidMoving);
        }

        private void Update()
        {
            _playerController.UpdateExecute();
            _asteroidMovingController.UpdateExecute();
        }

        private void FixedUpdate()
        {
            _playerController.FixedUpdateExecute();
            _asteroidMovingController.FixedUpdateExecute();
        }
    } 
}

