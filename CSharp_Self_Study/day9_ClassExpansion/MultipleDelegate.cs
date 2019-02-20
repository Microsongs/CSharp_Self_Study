using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    class MultipleDelegate
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x,int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(string[] args)
        {
            /*
            CalcDelegate calc = Add;
            calc += Subtract;
            calc += Multiply;
            calc += Divide;

            calc(10, 5);
            */
            CalcDelegate calc = new CalcDelegate(Add);
            CalcDelegate subtractCalc = new CalcDelegate(Subtract);
            CalcDelegate multiplyCalc = new CalcDelegate(Multiply);
            CalcDelegate divideCalc = new CalcDelegate(Divide);
            calc = CalcDelegate.Combine(calc, subtractCalc) as CalcDelegate;
            calc = CalcDelegate.Combine(calc, multiplyCalc) as CalcDelegate;
            calc = CalcDelegate.Combine(calc, divideCalc) as CalcDelegate;
            calc(10, 5);
        }
    }
}
