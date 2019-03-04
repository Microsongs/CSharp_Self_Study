using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day15_연산자
{
    //저번 시간 복습
    class Test : Attribute
    {
        string name;
        public Test(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    //저번 시간 복습
    [Test("비트 연산자")]
    class ShiftOperator
    {
        static void Main(string[] args)
        {
            //이번 시간 내용
            int n1 = -38;           //부호 있는 32비트 정수
            uint n2 = 2281709616;   //부호 없는 32비트 정수
            Console.WriteLine(n1 >> 2);
            Console.WriteLine(n2 >> 2);
        }
    }
}
