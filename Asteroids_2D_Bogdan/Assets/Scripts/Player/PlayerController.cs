using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class PlayerController : IUpdateExecute, IFixedUpdateExecute
    {
        private readonly PlayerView _playerView;
        public PlayerController(PlayerView playerView)
        {
            _playerView = playerView;
        }
        public void UpdateExecute()
        {
            
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

        public void FixedUpdateExecute()
        {
            _playerView.Rotate();
            _playerView.Move();
        }
    } 
}


