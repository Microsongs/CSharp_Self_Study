using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class BackgroundThread
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
        }
        static void threadFunc()
        {
            Console.WriteLine("10초 후에 프로그램 종료");
            Thread.Sleep(1000 * 10);    //10초동안 실행 중지
            Console.WriteLine("스레드 종료!");
        }
    }
}
