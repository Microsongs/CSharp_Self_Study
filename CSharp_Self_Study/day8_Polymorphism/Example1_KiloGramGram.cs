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
        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }
        public override string ToString()
        {
            return mass + "kg";
        }
    }
    class Gram
    {
        double mass;
        public Gram(double value)
        {
            this.mass = value;
        }
        public double Mass
        {
            get { return mass; }
        }
        public static explicit operator Kilogram(Gram gram)
        {
            return new Kilogram(gram.Mass / 1000);
        }
    }
    class Example1_KiloGramGram
    {
        static void Main(string[] args)
        {
            Kilogram k1 = new Kilogram(10);
            Kilogram k2 = new Kilogram(20);
            Kilogram k3 = k1 + k2;
            Console.WriteLine(k3);
            Gram g4 = new Gram(1000);
            Kilogram g5 = (Kilogram)g4; //명시적 형변환
            Console.WriteLine(g5);
        }
    }
}
