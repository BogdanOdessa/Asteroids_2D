using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}

