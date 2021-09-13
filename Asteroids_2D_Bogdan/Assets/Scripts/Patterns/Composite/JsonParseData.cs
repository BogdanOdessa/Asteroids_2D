using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids2D
{
    public class JsonParseData : MonoBehaviour
    {
        public TextAsset jsonFile;
        private CompositeFactory _compositeFactory;

        private void Start()
        {
           Units unitsFromJson = JsonUtility.FromJson<Units>("{\"units\":" + jsonFile.text + "}");
           
           foreach (var units in unitsFromJson.units)
           {
               Debug.Log($"{units.unit.type} {units.unit.health}");
           }

           _compositeFactory = new CompositeFactory(unitsFromJson);
           
           _compositeFactory.CreateUnits();

        }
    } 
}

