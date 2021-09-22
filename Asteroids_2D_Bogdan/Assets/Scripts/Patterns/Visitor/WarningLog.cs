using UnityEngine;

namespace Asteroids2D
{
    public class WarningLog : ILog
    {
        public void Log(int count)
        {
           Debug.LogWarning("Attention! Enemies count is " + count);
        }
    }
}