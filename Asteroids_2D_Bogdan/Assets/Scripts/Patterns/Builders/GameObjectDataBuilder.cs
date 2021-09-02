using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    internal sealed class GameObjectDataBuilder : GameObjectBuilder
    {
        public GameObjectDataBuilder(GameObject gameObject) : base(gameObject)
        {
            
        }

        public GameObjectDataBuilder AddAsteroidClass()
        {
            var component = GetOrAddComponent<Asteroid>();
            return this;
        }

         public GameObjectDataBuilder AddHp(float health)
         {
             var component = GetOrAddComponent<Asteroid>();
             component.hp = health;
             return this;
         }
        
        
        
        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }  
}


