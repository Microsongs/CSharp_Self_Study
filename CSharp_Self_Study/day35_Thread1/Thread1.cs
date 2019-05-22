using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class Thread1
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.Start();
        }
        static void threadFunc()
        {
            Console.WriteLine("ThreadFunc run!");
        }
    }
}
