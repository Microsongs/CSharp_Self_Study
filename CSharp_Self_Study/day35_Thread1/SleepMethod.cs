using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class SleepMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(1000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
