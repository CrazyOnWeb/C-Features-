using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7_0
{
    internal class OutVariables : UnUse
    {
        internal static void Descrition()
        {
            //
            // 新特性 1
            // 使用out参数时，不需要提前定义类型，在方法形参部分直接声明即可。
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }

        internal void PrintCoordinates(Point p)
        {
            // 讨厌它很久了，就感觉被强迫一样～～！
            int x, y; // have to "predeclare"

            p.GetCoordinates(out x, out y);

            WriteLine($"({x}, {y})");
        }

        internal void PrintCoordinates7_0(Point p)
        {
            // 在方法形参内声明类型，少了一行代码，这个感觉好
            p.GetCoordinates(out int x, out int y);

            WriteLine($"({x}, {y})");

            // out 参数可以定义为var型
            // 类型不是必须知道的时候，我希望不知道。
            if (int.TryParse("s", out var i)) {
                WriteLine(new string('*', i));
            }
            else {
                WriteLine("Cloudy - no stars tonight!");
            }

            // 懒人专用，如果能不写就更爽了。
            p.GetCoordinates(out var x1, out _);
        }
    }
}
