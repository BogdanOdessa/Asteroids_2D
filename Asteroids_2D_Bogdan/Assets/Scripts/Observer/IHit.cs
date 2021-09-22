using System;

namespace Asteroids2D
{
    public interface IHit
    {
        event Action<string> OnHitChange;
        void Hit(string name);

    }
}