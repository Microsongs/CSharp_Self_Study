using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class ElseIf
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int value = int.Parse(Console.ReadLine());
            if (value <= 255)
            {
                Console.WriteLine("byte 변환 가능");
            }
            else if (value <= 65535)
                Console.WriteLine("ushort 변환 가능");
            else
                Console.WriteLine("int타입");
        }
    }
}
