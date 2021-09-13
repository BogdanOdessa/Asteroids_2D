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
        private PointsCounter _pointsCounter;
        private CreatePlayerAbilities _createPlayerAbilities;

        private void Start()
        {
            _playerView = FindObjectOfType<PlayerView>();
            var gun = _playerView.playerShoot;
            _createPlayerAbilities = new CreatePlayerAbilities();
            
            _playerController = new PlayerController(_playerView,gun, _createPlayerAbilities.AbilitySelector);
           
            
            
            _pointsCounter = new PointsCounter();
            
            var facadeCreateEnemies = new FacadeCreateEnemies();
            _enemiesController = facadeCreateEnemies.CreateEnemiesWithController(enemyAmount, _pointsCounter);

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

        public int GetPointsAmount()
        {
            return _pointsCounter.PointsAmount;
        }
        
        public int GetDestroyedAsteroidsAmount()
        {
            return _pointsCounter.DestroyedAsteroidsAmount;
        }
    }  
}

