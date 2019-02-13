using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day5_Encapsulation
{
    class Circle
    {
        double pi = 3.14;
        double getArea(double radius)
        {
            return radius * radius * pi;
        }
        public void Print(double value)
        {
            Console.WriteLine(getArea(value));
        }
    }
    class EncapsulationBasic
    {
        static void Main(string[] args)
        {
            //원 생성
            Circle o = new Circle();
            //o.pi = 6.28;    //private 맴버에 접근 불가능
            //o.getArea(10);  //private 맴버에 접근 불가능
            o.Print(10);    //public 맴버에 접근 가능
        }
    }
}
