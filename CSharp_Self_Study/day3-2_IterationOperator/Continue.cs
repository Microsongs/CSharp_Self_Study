using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class Continue
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;

            while(n++ <= 1000)
            {
                if((n % 2 ) != 0)
                {
                    continue;   //아래 구문을 건너뛰고, while의 조건식 평가로 실행을 옮긴다.
                }
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
