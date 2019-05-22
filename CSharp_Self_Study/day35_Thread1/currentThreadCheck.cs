using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class currentThreadCheck
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.ThreadState);
        }
    }
}
