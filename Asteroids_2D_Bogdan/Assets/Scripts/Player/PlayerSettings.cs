using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Asteroids2D
{
    [CreateAssetMenu(fileName = "Settings", menuName = "CreateScriptableObject/PlayerSettings", order =  1)]
    public class PlayerSettings : ScriptableObject
    {
        [Range(0,10)] public float speed;
        [Range(0,10)] public float acceleration;
        public float hp;
        public Rigidbody2D bullet;
        public float force;
    } 
}

