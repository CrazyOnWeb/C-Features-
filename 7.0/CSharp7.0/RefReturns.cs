using System;

namespace CSharp7_0
{
    internal class RefReturns:UnUse
    {
        internal static void Descrition()
        {
            //
            // 新特性 7
            // 返回引用地址 类似指针
            // 具体如下↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
            //
        }
        public void RefReturn7_0()
        {
            Point[] array = { new Point(1,2), new Point(3, 2) };

            ref Point place = ref Find(7, array); // aliases 7's place in the array

            place = new Point(1,4); // replaces 7 with 9 in the array

            WriteLine(array[4]);
        }

        public ref Point Find(int number, Point[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Y == number)
                {
                    return ref numbers[i]; // return the storage location, not the value
                }
            }
            throw new IndexOutOfRangeException($"{nameof(number)} not found");

        }
    }
}