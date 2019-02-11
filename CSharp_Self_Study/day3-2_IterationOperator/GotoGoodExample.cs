using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class GotoGoodExample
    {
        static void Main(string[] args)
        {
            //goto의 유일한 사용처 -> 중첩 루프 탈출
            for(int x=2; x<10; x++)
            {
                for(int y=1; y<10; y++)
                {
                    Console.WriteLine(x + " * " + y + " = " + (x * y));

                    if (x == 5 && y == 8)
                        goto LOOP_EXIT;
                }
            }
        LOOP_EXIT:;
        }
    }
}
