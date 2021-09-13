using System.Collections.Generic;

namespace Asteroids2D
{
    public interface IPlayerAbilitySelector
    { 
        IPlayerAbility this[int index] { get; }
        string this[Target index] { get; }
        IEnumerable<IPlayerAbility> GetAbility();
        IEnumerator<IPlayerAbility> GetEnumerator();
    }
}