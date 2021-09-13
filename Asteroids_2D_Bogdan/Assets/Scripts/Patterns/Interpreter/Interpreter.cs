using System;
using UnityEngine;

namespace Asteroids2D
{
    public class Interpreter
    {
        public string ShortTheNumber(int points)
        {
            string result;
            if (points >= 1000000)
                result = (points/1000000) + "M";
            else if (points >= 1000)
                result = (points/1000) + "K";
            else
                result = points.ToString();
            return result;
        }
    }
}