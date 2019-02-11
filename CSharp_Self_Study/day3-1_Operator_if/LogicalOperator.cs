using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class LogicalOperator
    {
        static void Main(string[] args)
        {
            //논리 연산자
            int value = 10;
            int n1 = value % 3;
            int n2 = value % 5;

            bool orResult = (n1 == 0 || n2 == 0);
            Console.WriteLine("value는 3의 배수이거나 5의 배수 : " + orResult);

            bool andResult = (n1 == 0 && n2 == 0);
            Console.WriteLine("value는 3의 배수이면서 5의 배수 : " + andResult);

            bool notResult = !(n1 == 0);
            Console.WriteLine("value는 3의 배수가 아니다 : " + notResult);
        }
    }
}
