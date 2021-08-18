using System;
using System.Linq;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private PlayerView _playerView;
        private Rigidbody2D _rigidbody2D;
        
        public PlayerInitialize playerInitialize;
        public PlayerSettings playerSettings;

        private readonly float _enemyHp = 100f;
        private void Awake()
        {
            CreatePlayer();
            Enemy.CreateAsteroidEnemy(new Health(_enemyHp, _enemyHp));
            
            //IEnemyFactory factory = new AsteroidFactory();
            //factory.Create(new Health(100.0f, 100.0f));
            //Enemy.Factory.Create(new Health(100f, 100f));
        }

        private void CreatePlayer()
        {
            var player = PlayerCreate.CreatePlayer();
            
            _rigidbody2D = player.GetComponent<Rigidbody2D>();
            _playerView = FindObjectOfType<PlayerView>();

            var barrelTransform = _playerView.transform.GetChild(0);
            //_playerView.GetComponentInChildren<Transform>();
            
            playerInitialize = new PlayerInitialize(_playerView.transform, barrelTransform, 
                playerSettings.speed, playerSettings.acceleration, 
                playerSettings.bullet, playerSettings.force, _rigidbody2D);
            
            playerInitialize.InitializePlayer();
        }
        
    }
}