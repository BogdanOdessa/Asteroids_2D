using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class CreatePlayerAbilities
    {
        public PlayerAbilitySelector AbilitySelector { get; }
        public CreatePlayerAbilities()
        {
            var ability = new List<IPlayerAbility>
            {
                new PlayerAbility("Rush Attack", 100, Target.None),
                new PlayerAbility("Asteroid Destroyer ", 200, Target.Asteroid),
                new PlayerAbility("EnemyShip Hunt", 300, Target.EnemyShip),
            };
            AbilitySelector = new PlayerAbilitySelector(ability);
            var abilities = AbilitySelector.GetAbility();
        }
        
    }
}
