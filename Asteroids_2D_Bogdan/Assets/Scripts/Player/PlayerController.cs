using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerController
    {
        private readonly PlayerView _playerView;
        public PlayerController(PlayerView playerView)
        {
            _playerView = playerView;
        }
        public void Execute()
        {
            _playerView.Rotate();
            _playerView.Move();
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _playerView.Accelerate();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _playerView.DeAccelerate();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _playerView.Shoot();
            }
        }
    } 
}


