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

        public double GetPi()
        {
            return pi;
        }
        public void SetPi(double value)
        {
            pi = value;
        }
    }
    class InformationHiding
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.SetPi(3.14159);
            double piValue = o.GetPi();
            Console.WriteLine(piValue);
        }
    }
}
