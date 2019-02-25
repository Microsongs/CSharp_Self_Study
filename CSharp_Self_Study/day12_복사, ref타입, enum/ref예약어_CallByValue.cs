using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    struct Vector
    {
        public int X;
        public int Y;
    }
    class ref예약어_CallByValue
    {
        static void Main(string[] args)
        {
            Vector v1;
            v1.X = 5;
            v1.Y = 10;

            Change(ref v1); //메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);
        }
        static void Change(ref Vector v1)   //메서드에서도 해당 매개변수에 ref 예약어 사용
        {
            v1.X = 7;
            v1.Y = 14;
        }
    }
}
