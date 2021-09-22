using UnityEngine;

namespace Asteroids2D
{
    public class DebugLog : ILog
    {
        public void Log(int count)
        {
            Debug.Log("Enemy count is " + count);
        }
    }
}