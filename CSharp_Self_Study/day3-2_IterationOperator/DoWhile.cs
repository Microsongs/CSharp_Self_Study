using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;
            do
            {
                if (n % 2 == 0)
                    sum += n;
            } while (++n <= 1000);
            Console.WriteLine(sum);
        }
    }
}
