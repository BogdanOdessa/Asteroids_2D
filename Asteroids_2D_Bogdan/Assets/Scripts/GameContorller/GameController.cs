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
        
        private  List<AsteroidMovingController> _enemiesController;
        [SerializeField]private int enemyAmount = 100;

        private EnemyShipController enemyShipContoller;

        private void Start()
        {
            _playerView = FindObjectOfType<PlayerView>();
            var gun = _playerView.playerShoot;
            _playerController = new PlayerController(_playerView,gun);
            
            var facadeCreateEnemies = new FacadeCreateEnemies();
            _enemiesController = facadeCreateEnemies.CreateEnemiesWithController(enemyAmount);

            enemyShipContoller = Enemy.CreateEnemyShipController();
        }

        private void Update()
        {
            _playerController.UpdateExecute();
            foreach (var t in _enemiesController)
            {
                t.UpdateExecute();
            }
            enemyShipContoller.UpdateExecute();
        }

        private void FixedUpdate()
        {
            _playerController.FixedUpdateExecute();
            
            
            foreach (var t in _enemiesController)
            {
                t.FixedUpdateExecute();
            }
        }
        
    }  
}

