using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class ThreadParam
    {
        public int value1;
        public int value2;
    }
    class 스레드_메서드에_인자_전달
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            ThreadParam param = new ThreadParam();
            param.value1 = 10;
            param.value2 = 20;
            t.Start(param);
        }
        static void threadFunc(object initialValue)
        {
            ThreadParam value = initialValue as ThreadParam;
            Console.WriteLine("{0}, {1}", value.value1, value.value2);
        }
    }
}
