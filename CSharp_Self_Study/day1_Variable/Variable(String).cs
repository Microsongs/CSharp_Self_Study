using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day1_Variable
{
    class Variable_String_
    {
        static void Main(String[] args)
        {
            //char의 사용
            char ch1 = '\t';
            char ch2 = 'T';
            char ch3 = '\n';
            char ch4 = 'o';

            Console.Write(ch1);
            Console.Write(ch2);
            Console.Write(ch3);
            Console.Write(ch4);

            //string의 사용
            string text = "\tHello\nWorld";
            Console.WriteLine(text);
        }
    }
}
