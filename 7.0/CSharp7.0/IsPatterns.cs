using System;

namespace CSharp7_0
{
    internal class IsPatterns:UnUse
    {
        internal static void Descrition()
        {
            //
            // 新特性 2
            // Is 表达式
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }

        internal void PrintStars(object o)
        {

            if (o is null) return;     // constant pattern "null"

            if (!(o is int i)) return; // type pattern "int i"

            WriteLine(new string('*', i));
        }

        internal void PrintStars7_0(object o)
        {
            if (o is int i || (o is string s && int.TryParse(s, out i))) { /* use i */ }
        }
    }
}