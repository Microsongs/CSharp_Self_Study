using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class Switch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("남성은 M, 여성은 F : ");
                char ch = char.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 'M':
                        Console.WriteLine("Male");
                        break;
                    case 'F':
                        Console.WriteLine("Female");
                        break;
                    default:
                        Console.WriteLine("알 수 없음");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("올바른 입력을 해주세요.");
            }
        }
    }
}
