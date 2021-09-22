using UnityEngine;

namespace Asteroids2D
{
    public sealed class FirsStateMovingSlow : State
    {
        public override void Handle(Context context)
        {
            
            context.State = new SecondStateMovingFast();
            Debug.Log("State: " + context.State.GetType().Name);
        }
    }

}