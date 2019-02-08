using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day2_Basic
{
    class TypeCasting
    {
        static void Main(String[] args)
        {
            //암시적 변환
            byte b = 10;
            short s = b;
            Console.WriteLine(s);

            //명시적 변환
            ushort u = 65;
            char c = (char)u;   //char로 형변환하지 않으면 오류 발생
            Console.WriteLine(c);
        }
    }
}
