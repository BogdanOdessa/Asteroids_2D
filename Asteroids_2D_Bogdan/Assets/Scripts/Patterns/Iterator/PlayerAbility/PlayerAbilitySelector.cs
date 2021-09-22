using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace Asteroids2D
{
    public class PlayerAbilitySelector : IPlayerAbilitySelector
    {
        private List<IPlayerAbility> _abilities;
        public PlayerAbilitySelector(List<IPlayerAbility> abilities)
        {
            _abilities = abilities;
        }

        public IPlayerAbility this[int index] => _abilities[index];

        public string this[Target index]
        {
            get {  var ability = _abilities.FirstOrDefault(a => a.Target == index);
                return ability == null ? "Not supported" : ability.ToString(); }
        }

        public IEnumerable<IPlayerAbility> GetAbility()
        {
            for (var i = 0; i < _abilities.Count; i++)
            {
                yield return _abilities[i];
            }
        }

        public IEnumerator<IPlayerAbility> GetEnumerator()
        {
            for (var i = 0; i < _abilities.Count; i++)
            {
                yield return _abilities[i];
            }
        }

        public IPlayerAbility GetAbilityByIndex(int index)
        {
            for (var i = 0; i < _abilities.Count; i++)
            {
                if (i == index)
                {
                    return _abilities[i];
                }
            }

            return null;
        }
        
        public IPlayerAbility GetRandomAbility()
        {
            var abilityRandomNumber = Random.Range(0, _abilities.Count);
            return _abilities[abilityRandomNumber];
        }
        
    }
}