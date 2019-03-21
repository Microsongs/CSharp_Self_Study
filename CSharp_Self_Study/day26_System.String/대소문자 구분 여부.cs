using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day26_System.String
{
    class 대소문자_구분_여부
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";

            Console.WriteLine(txt + " EndsWith(\"WORLD\"): " + txt.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " IndexOf(\"WORLD\"): " + txt.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " StartsWith(\"HELLO\"): " + txt.StartsWith("HELLO", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
        }
    }
}
