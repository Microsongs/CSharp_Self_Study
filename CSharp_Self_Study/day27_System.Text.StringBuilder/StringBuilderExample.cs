using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class StringBuilderExample
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";
            System.Text.StringBuilder stb = new System.Text.StringBuilder();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            stb.Append(txt);
            for (int i=0; i<300000; i++)
            {
                stb.Append("1");
            }
            string newText = stb.ToString();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
