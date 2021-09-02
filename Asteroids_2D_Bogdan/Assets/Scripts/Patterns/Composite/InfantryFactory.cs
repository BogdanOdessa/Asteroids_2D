using UnityEngine;

namespace Asteroids2D
{
    public class InfantryFactory : ICreateUnit
    {

        public void CreateUnit(Unit unit)
        {
            var infantry = Object.Instantiate(Resources.Load<GameObject>("Test/Infantry"));
            infantry.name = unit.unit.type;
            var infantryHp = new UnitHp(unit.unit.health);
        }
    }
}