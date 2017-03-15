using System;

namespace CSharp7_0
{
    internal class LiteralImprovements
    {
        internal static void Descrition()
        {
            //
            // 新特性 6
            // 文字描述改进
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }

        public void Literal7_0()
        {
            // 2进制 0b
            var b = 0b1010_1011_1100_1101_1110_1111;
            // 10进制
            var d = 123_456;
            // 16进制 0x
            var x = 0xAB_CD_EF;
        }
    }
}