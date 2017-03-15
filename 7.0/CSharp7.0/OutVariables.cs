using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7_0
{
    public class OutVariables : UnUser
    {
        public static void Descrition()
        {
            //
            // 新特性 1
            // 使用out参数时，不需要提前定义类型，在方法形参部分直接声明即可。
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }

        public void PrintCoordinates(Point p)
        {
            int x, y; // have to "predeclare"

            p.GetCoordinates(out x, out y);

            WriteLine($"({x}, {y})");
        }

        public void PrintCoordinates7_0(Point p)
        {

            p.GetCoordinates(out int x, out int y);

            WriteLine($"({x}, {y})");

            if (int.TryParse("s", out var i)) {
                WriteLine(new string('*', i));
            }
            else {
                WriteLine("Cloudy - no stars tonight!");
            }

            // 因为没有用到 "_" 这样写可以忽略声明
            p.GetCoordinates(out var x1, out _);
        }
    }
}
