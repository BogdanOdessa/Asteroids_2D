using UnityEngine;

namespace Asteroids2D
{
    public class SecondStateMovingFast : State
    {
        public override void Handle(Context context)
        {
          
            context.State = new FirsStateMovingSlow();
            Debug.Log("State: " + context.State.GetType().Name);
        }
    }
}