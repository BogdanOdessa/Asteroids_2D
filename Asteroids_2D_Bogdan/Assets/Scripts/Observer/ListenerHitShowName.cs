using System;
using  UnityEngine;

namespace Asteroids2D
{
    public sealed class ListenerHitShowName
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnOnHitChange;
        }

        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnOnHitChange;
        }

        private void ValueOnOnHitChange(string name)
        {
            Debug.Log(name);
        }
    }

}