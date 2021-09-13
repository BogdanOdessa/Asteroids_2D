using System;
using UnityEngine;

namespace Asteroids2D
{
    [Serializable]internal sealed class ExamplePrototype : MonoBehaviour
    {
        private void Start()
        {
            PlayerData playerData = new PlayerData
            {
                hp = new Hp
                {
                    currentHp = 100,
                    maxHp = 100
                },
                speed = 100
            };
            
            PlayerData playerDataNew = playerData.DeepCopy();
            playerDataNew.hp.currentHp = 200;
            
            Debug.Log(playerData);
            Debug.Log(playerDataNew);
        }
    }
}