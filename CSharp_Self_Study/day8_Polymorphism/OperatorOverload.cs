using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day8_Polymorphism
{
    class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }
        //연산자 오버로딩 정의
        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }
        public override string ToString()
        {
            return mass + "kg";
        }
    }
    class OperatorOverload
    {
        static void Main(string[] args)
        {
            Kilogram kilo = new Kilogram(5);
            Kilogram gram = new Kilogram(10);
            Kilogram kilogram = kilo + gram;    //연산자 오버로딩 사용
        }
    }
}
