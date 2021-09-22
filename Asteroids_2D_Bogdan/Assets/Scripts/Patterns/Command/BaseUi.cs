using UnityEngine;

namespace Asteroids.Command.Second
{
    internal abstract class BaseUi : MonoBehaviour
    {
        public abstract void Execute();  
        public abstract void Cancel();
       
    }
}