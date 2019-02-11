using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class While
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            while(n <= 1000)
            {
                if(n % 2 == 0)
                {
                    sum += n;
                }
                n++;
            }
            Console.WriteLine(sum);
        }
    }
}
