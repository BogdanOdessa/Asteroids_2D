using System;
using System.Collections.Generic;
using Asteroids2D;
using UnityEngine;

namespace Asteroids2D
{
    [Serializable]
    public class CompositeFactory 
    {
        private readonly Units _units;
        private MagFactory _magFactory;
        private InfantryFactory _infantryFactory;

        public CompositeFactory(Units units)
        {
            _units = units;
            _magFactory = new MagFactory();
            _infantryFactory = new InfantryFactory();
        }
        
        public void CreateUnits()
        {
            foreach (var unit in _units.units)
            {
                if (unit.unit.type == "mag")
                {
                    _magFactory.CreateUnit(unit);
                }

                if (unit.unit.type == "infantry")
                {
                    _infantryFactory.CreateUnit(unit);
                }
            }
        }
    }
    
}