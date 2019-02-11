using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_1_Operator_if
{
    class Switch2
    {
        static void Main()
        {
            Console.Write("사용중인 언어 입력 : ");
            string value = Console.ReadLine();

            switch (value)
            {
                case "C#":
                case "VB.NET":
                    Console.WriteLine(".Net 호환 언어");
                    break;
                case "Java":
                    Console.WriteLine("JVM 언어");
                    break;
                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }
        }
    }
}
