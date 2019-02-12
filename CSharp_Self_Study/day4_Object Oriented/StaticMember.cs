using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Person
    {
        public static int CountOfInstance;  //static 예약어로 정적 필드 생성
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }
    }
    class StaticMember
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.CountOfInstance);
            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");
            Console.WriteLine(Person.CountOfInstance);
        }
    }
}
