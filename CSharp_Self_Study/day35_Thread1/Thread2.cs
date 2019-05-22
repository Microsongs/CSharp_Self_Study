using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day35_Thread1
{
    class Thread2
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.Start();
            //더는 주 스레드가 실행할 명령어가 없으므로 주 스레드 제거
            Thread.Sleep(1000);
            Console.WriteLine("주 스레드 제거");
        }
        static void threadFunc()
        {
            Console.WriteLine("10초 후에 프로그램 종료");
            Thread.Sleep(1000 * 10);    //10초동안 실행 중지
                                        //현재 주 스레드는 종료되었어도 t 스레드는 존속
            Console.WriteLine("스레드 종료!");
        }
    }
}
