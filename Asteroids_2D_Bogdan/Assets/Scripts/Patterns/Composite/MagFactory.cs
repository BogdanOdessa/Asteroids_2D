using Unity.Mathematics;
using UnityEngine;

namespace Asteroids2D
{
    public class MagFactory : ICreateUnit
    {
        public void CreateUnit(Unit unit)
        {
            var mag = Object.Instantiate(Resources.Load<GameObject>("Test/Mag"));
            mag.name = unit.unit.type;
            var magHp = new UnitHp(unit.unit.health);
        }
    }
}