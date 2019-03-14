using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day22_HeapAndStack
{
    class RecursiveCall_Factorial_
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
        static long factorial(long n)
        {
            if (n == 0)
                return 1L;
            return n * factorial(n - 1);
        }
    }
}
