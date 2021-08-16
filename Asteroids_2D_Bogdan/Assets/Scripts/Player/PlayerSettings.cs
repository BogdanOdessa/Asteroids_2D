using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    [CreateAssetMenu(fileName = "Settings", menuName = "CreateScriptableObject/PlayerSettings", order =  1)]
    public class PlayerSettings : ScriptableObject
    {
        [Range(0,10)]
        public float _speed;
    
        [Range(0,10)] public float _acceleration;
        [SerializeField] public float _hp;
        [SerializeField] public Rigidbody2D _bullet;
        [SerializeField] public float _force;
    } 
}

