using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Asteroids2D
{
    public static class ViewServices
    {
       
        private static readonly Dictionary<string, ObjectPool> _viewCache = new Dictionary<string, ObjectPool>(12);

        public static GameObject Instantiate(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.name] = viewPool;
            }

            var gameObject = viewPool.Pop();
            return gameObject;
        }

        public static void Destroy(GameObject value)
        {
            
            _viewCache[value.name].Push(value);
        }
        
        
    }

}
