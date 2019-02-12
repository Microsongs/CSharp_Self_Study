using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Person
    {
        static int CountOfInstance; //private 정적 필드
        public string _name;

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }

        public static void OutputCount()    //public 정적 메서드
        {
            Console.WriteLine(CountOfInstance); //정적 메서드에서 정적 필드 접근
        }
    }
    class StaticMethod
    {
        static void Main(string[] args0){
            Person.OutputCount();   //정적 메서드는 클래스 이름으로 호출 가능
            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");
            Person.OutputCount();   //출력 결과 : 2
        }
    }
}
