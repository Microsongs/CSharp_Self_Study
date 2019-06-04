using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day37_Thread3
{
    class ThreadLock
    {
        //멀티스레드의 동기화
        int number = 0;
        static void Main(string[] args)
        {
            ThreadLock pg = new ThreadLock();

            Thread t1 = new Thread(threadFunc);
            Thread t2 = new Thread(threadFunc);

            //2개의 스레드 시작
            t1.Start(pg);
            t2.Start(pg);

            //2개의 스레드 실행이 끝날 떄 까지 대기
            t1.Join();
            t2.Join();

            Console.WriteLine(pg.number);   //스레드 실행 완료 후 number 필드 값 출력
        }

        static void threadFunc(object inst)
        {
            ThreadLock pg = inst as ThreadLock;

            for(int i=0; i<100000; i++)
            {
                lock (pg)
                {
                    pg.number++;
                }
            }
        }
    }
}
