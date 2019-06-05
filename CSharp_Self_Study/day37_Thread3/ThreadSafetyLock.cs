using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day37_Thread3
{
    class MyData
    {
        int number = 0;
        public object _numberLock = new object();

        public int Number { get { return number; } }

        public void Increment()
        {
            lock (_numberLock)
            {
                number++;
            }
        }
    }
    class ThreadSafetyLock
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();

            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);

            t1.Start(data);
            t2.Start(data);

            t1.Join();
            t2.Join();

            Console.WriteLine(data.Number);
        }

        static void threadFunc(object inst)
        {
            MyData data = inst as MyData;

            for (int i = 0; i < 120000; i++)
            {
                data.Increment();
            }
        }
    }
}
