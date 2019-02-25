using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    class ref예약어_기본_자료형
    {
        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 10;

            Swap1(value1, value2);
            Console.WriteLine("value1 = " + value1 + ", value2 = " + value2);
            SwapValue(ref value1, ref value2);
            Console.WriteLine("value1 = " + value1 + ", value2 = " + value2);
        }
        static void Swap1(int value1, int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void SwapValue(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
