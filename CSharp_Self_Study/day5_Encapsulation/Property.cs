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

        public double Pi
        {
            get { return pi; }
            set { pi = value; } //set블록에서만 사용할 수 있는 value 예약어
        }
    }
    class Property
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.Pi = 3.14159;         //set
            double piValue = o.Pi;  //get
            Console.WriteLine(piValue);
        }
    }
}
