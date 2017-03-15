using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7_0
{
    public class UnUse
    {
        public void WriteLine(dynamic v)
        {
            throw new NotImplementedException();
        }

        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) { X = x; Y = y; }
            public void Deconstruct(out int x, out int y) { x = X; y = Y; }

            public void GetCoordinates(out int x, out int y)
            {
                throw new NotImplementedException();
            }
        }

        public class Shape
        {

        }
        public class Circle : Shape
        {
            public object Radius { get; internal set; }
        }

        public class Rectangle : Shape
        {
            public object Length { get; internal set; }
            public object Height { get; internal set; }
        }
    }
}
