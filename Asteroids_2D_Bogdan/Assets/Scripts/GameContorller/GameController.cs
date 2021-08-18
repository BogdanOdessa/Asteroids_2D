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
        void Start()
        {
            _playerView = FindObjectOfType<PlayerView>();
            _playerController = new PlayerController(_playerView);
        }

        private void Update()
        {
            _playerController.UpdateExecute();
        }

        private void FixedUpdate()
        {
            _playerController.FixedUpdateExecute();
        }
    } 
}

