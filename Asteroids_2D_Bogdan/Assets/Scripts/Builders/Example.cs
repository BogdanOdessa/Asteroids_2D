using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        
        private void Start()
        {
            var gameObjectBuilder = new GameObjectBuilder();

            GameObject player = gameObjectBuilder.Visual.Name("Bogdan").Sprite(_sprite).Physics.Rigidbody2D(1f)
                .BoxCollider2D();
            
            var enemy = new GameObject().SetName("Enemy").AddBoxCollider2D().AddBoxCollider2D().AddRigidbody2D(2.0f).AddSprite(_sprite);
        }

    }

}
