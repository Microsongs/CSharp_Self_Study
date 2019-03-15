using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day23_heap
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int a = 5;
            object obj = a; //박싱 : 값 형식인 int를 참조 형식인 object에 대입
            int b = (int)obj;   //언박싱 : 참조 형식인 object를 값 형식인 int에 대입
            Console.WriteLine(obj);
            Console.WriteLine(a);
        }
    }
}
