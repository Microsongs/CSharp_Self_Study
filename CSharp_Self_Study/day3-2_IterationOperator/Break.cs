using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class Break
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (true)
            {
                int j = 1;
                while (true)
                {
                    Console.WriteLine(i + "*" + j + "=" + (i * j));

                    if(++j > 9)
                    {
                        break;  //j값이 9 초과일 경우 탈출
                    }
                }

                if(++i > 9)
                {
                    break;  //i값이 9 초과일 경우 탈출
                }
            }
        }
    }
}
