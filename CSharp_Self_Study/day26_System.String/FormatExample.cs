using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day26_System.String
{
    class FormatExample
    {
        static void Main()
        {
            string txt = "날짜: {0,-20:D}, 판매 수량: {1,15:N}";
            Console.WriteLine(txt, DateTime.Now, 267);
        }
    }
}
