using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Person
    {
        public static Person President = new Person("대통령"); //public 정적 필드
        string _name;

        private Person(string name) //private 인스턴스 생성자, 외부에서는 접근할 수 없다.
        {
            _name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }
    class Singleton
    {
        public static void Main(string[] args)
        {
            //Person person = new Person("대통령");    //private 생성자이므로 접근할 수 없다
            Person.President.DisplayName(); //정적 필드로 단일 인스턴스에 접근
        }
    }
}
