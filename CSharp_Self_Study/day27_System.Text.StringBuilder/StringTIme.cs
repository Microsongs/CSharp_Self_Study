using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class StringTIme
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string txt = "Hello World";
            for(int i=0; i<300000; i++)
            {
                txt += "1";
            }
            watch.Stop();
            Console.WriteLine("소요 시간 : " + watch.Elapsed);
        }



    }
}
