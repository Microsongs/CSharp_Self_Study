using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class RelationOperator
    {
        static void Main(string[] args)
        {
            int value = 6;
            int n = value % 3;
            bool result = (n == 0); //6을 3으로 나눈 나머지는 0이다.

            Console.WriteLine(result);
        }
    }
}
