using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day22_HeapAndStack
{
    class RecursiveCall_Overflow
    {
        static void Main(string[] args)
        {
            RecursiveCall(1);
        }
        static void RecursiveCall(long n)
        {
            int i = 5, j = 6, k = 7;    //지역변수로 의해 12byte 스택 소비
            Console.WriteLine(n);
            RecursiveCall(n + 1);
        }
    }
}
