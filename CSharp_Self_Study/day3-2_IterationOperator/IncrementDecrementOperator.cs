using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class IncrementDecrementOperator
    {
        static void Main(string[] args)
        {
            //증감 연산자
            int n = 50;
            Console.WriteLine("기본값 : " + n);
            Console.WriteLine(n++);
            Console.WriteLine(n--);
            Console.WriteLine("현재까지의 값 : " + n);
            Console.WriteLine(++n);
            Console.WriteLine(--n);
        }
    }
}
