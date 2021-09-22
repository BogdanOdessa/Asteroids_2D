using UnityEngine;

namespace Asteroids2D
{
    public sealed class EnemyCount : EnemyCountLog
        {
            public override void Activate(ILog value)
            {
                var enemiesCount = Object.FindObjectsOfType<AsteroidMovingView>().Length;
                value.Log(enemiesCount);
            }
        }
}
