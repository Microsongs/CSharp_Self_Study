using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class JoinMethod
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
            t.Join();   //t 스레드가 종료할 떄 까지 현재 스레드를 무한 대기
            Console.WriteLine("주 스레드 종료");
        }
        static void threadFunc()
        {
            Console.WriteLine("10초 후에 프로그램 종료");
            Thread.Sleep(1000 * 10);
            Console.WriteLine("스레드 종료");
        }
    }
}
