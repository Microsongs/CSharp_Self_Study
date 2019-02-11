using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class Else
    {
        static void Main(string[] args)
        {
            int value = 5;
            if(value % 2 == 0)
            {
                Console.WriteLine("value는 2의 배수");
                Console.WriteLine("따라서 value는 짝수이다.");
            }
            else
            {
                Console.WriteLine("value는 홀수이다.");
            }
        }
    }
}
