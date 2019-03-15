using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day23_heap
{
    class MethodBoxing
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int c = GetMaxValue(a, b);
        }
        static int GetMaxValue(object v1,object v2)
        {
            int a = (int)v1;
            int b = (int)v2;

            if (a >= b)
                return a;

            return b;
        }
    }
}
