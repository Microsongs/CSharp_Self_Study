using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day13_맴버_유형_확장
{
    class const_literal
    {
        static void Main(string[] args)
        {
            /*
            //const 리터럴 사용 전
            int x = 5;
            int y = 10;

            Console.WriteLine("x 변수의 값 : " + x);
            Console.WriteLine("y 변수의 값 : " + y);
            */

            //const 리터럴 사용 후
            const string TEXT = " 변수의 값 : ";
            int x = 5;
            int y = 10;
            Console.WriteLine("x" + TEXT + x);
            Console.WriteLine("y" + TEXT + y);
        }
    }
}
