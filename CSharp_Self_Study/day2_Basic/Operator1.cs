using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day2_Basic
{
    class Operator1
    {
        static void Main(string[] args)
        {
            int n = 5;
            int divider = 3;
            int mod = n % divider;
            Console.WriteLine(mod); //5%3 == 2
        }
    }
}
