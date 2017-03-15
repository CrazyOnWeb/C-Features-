using System;

namespace CSharp7_0
{
    internal class SwitchPatterns:UnUse
    {
        private Shape _shape = new Rectangle();

        internal static void Descrition()
        {
            //
            // 新特性 3
            // 关于switch
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }

        internal void Switch7_0()
        {
            // 不限于switch类型，任何类型都行
            switch (_shape)
            {
                case Circle c:
                    WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when (s.Length == s.Height):
                    WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
                default:
                    WriteLine("<unknown shape>");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(_shape));

            }
        }

        
    }
}