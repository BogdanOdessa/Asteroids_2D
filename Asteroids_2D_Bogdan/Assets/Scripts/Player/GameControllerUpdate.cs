using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class GameControllerUpdate : MonoBehaviour
    {
         private PlayerController _playerController;
         private PlayerView _playerView;

         private PlayerInitialize _playerInitialize;

         private void Awake()
         {
             _playerView = FindObjectOfType<PlayerView>();
         }

         void Start()
        {
            
            _playerController = new PlayerController(_playerView);
        }
        void Update()
        {
            _playerController.Execute();
        }
    } 
}

