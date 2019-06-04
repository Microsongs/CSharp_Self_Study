using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day36_Thread2
{
    class MultiThread1
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Thread t = new Thread(threadFunc);
                t.Start(i);
            }
        }
        static void threadFunc(object value)
        {
            Console.WriteLine(value + "번 쨰 스레드");
        }
    }
}
