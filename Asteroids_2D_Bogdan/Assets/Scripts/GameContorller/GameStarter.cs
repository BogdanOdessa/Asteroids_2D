using System;
using System.Linq;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class GameStarter : MonoBehaviour
    {
        public PlayerInitialize _playerInitialize;
        private PlayerView _playerView;
        public PlayerSettings playerSettings;
        
        private void Awake()
        {
            var player = PlayerCreate.CreatePlayer();
            
            _playerView = FindObjectOfType<PlayerView>();
            var barrelTransform = _playerView.GetComponentInChildren<Transform>();
            
            _playerInitialize = new PlayerInitialize(_playerView.transform, barrelTransform, 
                playerSettings.speed, playerSettings.acceleration, 
                playerSettings.bullet, playerSettings.force);
            
            _playerInitialize.Init();

            Enemy.CreateAsteroidEnemy(new Health(100f, 100f));
            
            //IEnemyFactory factory = new AsteroidFactory();
            //factory.Create(new Health(100.0f, 100.0f));
            //Enemy.Factory.Create(new Health(100f, 100f));
        }

        private void Start()
        {
           
        }
    }
}