using UnityEngine;

namespace Asteroids2D
{
    public sealed class Context
    {
        private State _state;

        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            set => _state = value;

            get => _state;
        }

        public void ChangeState()
        {
            _state.Handle(this);
        }
    }

}