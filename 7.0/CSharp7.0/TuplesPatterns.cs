using System;

namespace CSharp7_0
{
    internal class TuplesPatterns:UnUse
    {
        internal static void Descrition()
        {
            //
            // 新特性 4
            // Tuples
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }
        public (string City, string State) GetCityAndState()
        {
            //return ("Lake Charles", "Louisiana");
            return (City: "Lake Charles", State: "Lake Charles");
        }
        public void Tuples7_0()
        {
            // (string city, string state) = GetCityAndState();
            // (var city, var state) = GetCityAndState();
            //(var city, var _) = GetCityAndState();
            //(var city, _) = GetCityAndState();
            // var (city, state) = GetCityAndState();
            /*
                var tuples = GetCityAndState();
                var city = tuples.City;
                var state = tuples.State;
            */
            //(var myX, var myY) = GetPoint();
            (var myX, _) = GetPoint();
        }

        private (int x, int y) GetPoint()
        {
            new Point(1, 2).Deconstruct(out var x, out var y);
            return (x,y);
        }
    }
}