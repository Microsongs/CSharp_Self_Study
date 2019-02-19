using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day8_Polymorphism
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class MethodOverride
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Mammal one = lion;
            one.Move();
            Mammal two = new Whale();
            two.Move();
        }
    }
}
