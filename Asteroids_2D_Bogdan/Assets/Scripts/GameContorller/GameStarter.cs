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

        private GameObject _enemy;
        [SerializeField] private Sprite _enemySprite;
        [SerializeField] private Transform _enemyPosition;
        
        
        private void Awake()
        {
            CreatePlayer();

            var gameObjectBuilder = new GameObjectBuilder();

            _enemy = gameObjectBuilder.
                Visual.Name("Enemy").Sprite(_enemySprite).Color(Color.blue).TransformPosition(_enemyPosition).
                Physics.BoxCollider2D().
                AddDatas.AddAsteroidClass().AddHp(_enemyHp);
            
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