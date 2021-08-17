using System;
using UnityEngine;

namespace Asteroids2D
{
    public abstract class PlayerCreate : MonoBehaviour
    {
        public PlayerHP PlayerHp { get; protected set; }
        public PlayerSettings playerSettings;

        private void Awake()
        {
            playerSettings = FindObjectOfType<PlayerSettings>();
        }

        public static GameObject CreatePlayer()
        {
            var player = Instantiate(Resources.Load<GameObject>("Player"));
            return player;
        }
        
    }
}