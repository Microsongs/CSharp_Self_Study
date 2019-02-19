using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day8_Polymorphism
{
    class Mammal
    {
        public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }
    class Lion : Mammal
    {
        new public void Move()
        {
            Console.WriteLine("네 발로 이동한다.");
        }
    }
    class Whale : Mammal
    {
        new public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }
    class New_UseByChildClass
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Move();    //순수하게 자식 클래스로 생성하면 자식 클래스의 Move가 호출
            Mammal mammal = new Whale();
            mammal.Move();  //부모 클래스로 선언하여 자식 객체로 생성하면 부모 클래스의 Move가 호출
        }
    }
}
