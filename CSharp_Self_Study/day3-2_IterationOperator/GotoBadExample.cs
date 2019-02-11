using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class GotoBadExample
    {
        static void Main(string[] args)
        {
            //goto문의 나쁜 예제
            int sum = 0;
            int n = 0;
        LOOP:
            n++;
            if(n > 1000)
            {
                goto LOOPEXIT;
            }

            if ((n % 2) != 0)
                goto LOOP;

            sum += n;
            goto LOOP;
        
        LOOPEXIT:
            Console.WriteLine(sum);
        }
    }
}
