using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class NestedLoopFor
    {
        static void Main(string[] args)
        {
            //중첩 for문
            for (int x = 2; x < 10; x++)
                for (int y = 1; y < 10; y++)
                    Console.WriteLine(x + "*" + y + "=" + (x * y));
        }
    }
}
