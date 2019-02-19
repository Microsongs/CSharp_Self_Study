using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day8_Polymorphism
{
    class Mathematics
    {
        //기존의 정의 방식
        /*
        public static int AbsInt(int value)
        {
            return (value >= 0) ? value : -value;
        }
        public static double AbsDouble(double value)
        {
            return (value >= 0) ? value : -value;
        }
        public static decimal AbsDecimal(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
        */
        //메서드 오버로드를 사용한 정의 방식
        public static int Abs(int value)
        {
            return (value >= 0) ? value : -value;
        }
        public static double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }
        public static decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    }
    class MethodOverload
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Abs(5));
            Console.WriteLine(Mathematics.Abs(-5.12));
        }
    }
}
