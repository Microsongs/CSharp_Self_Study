using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Person
    {
        public string _name;    //인스턴스 필드

        public Person(string name)  //인스턴스 생성자
        {
            _name = name;
        }
        public void OutputYourName()    //인스턴스 메서드
        {
            Console.WriteLine(_name);
        }
    }
    class InstanceMember
    {
        public static void Main(string[] args)
        {
            Person person = new Person("홍길동");  //new를 통해 인스턴스 생성자에 접근
            person.OutputYourName();    //new로 생성된 객체의 인스턴스 메서드를 호출
            Console.WriteLine(person._name);    //new로 생성된 객체의 인스턴스 필드에 접근
        }
    }
}
