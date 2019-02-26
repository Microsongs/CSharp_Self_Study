using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day13_맴버_유형_확장
{
    //이벤트를 사용한 콜백 메서드 사용
    class PrimeCallbackArg : EventArgs    //콜백 값을 담는 클래스 정의
    {
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    //소수 생성기 : 소수가 발생할 떄 마다 등록된 콜백 메서드 호출
    class PrimeGenerator
    {
        //PrimeDelegate, AddDelegate, RemoveDelegate 맴버 제거 후 생성
        public event EventHandler PrimeGenerated;
        //주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && PrimeGenerated != null)
                {
                    //콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }
        //소수 판정 메서드
        private bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
                return candidate == 2;
            for (int i = 3; (i * i) <= candidate; i += 2)
                if ((candidate % i) == 0)
                    return false;
            return candidate != 1;
        }
    }
    //콜백 메서드를
    class eventPrimeNumber
    {
        //콜백으로 등록될 메서드1
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }
        static int Sum;
        //콜백으로 등록될 메서드2
        static void SumPrime(object sender, EventArgs arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }
        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            //PeinrPeimw 메서드로 이벤트 구독
            gen.PrimeGenerated += PrintPrime ;
            //SumPrime 메서드로 이벤트 구독
            gen.PrimeGenerated += SumPrime;
            //1~10까지 소수를 구하기
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);
            //sumPrime의 메서드의 이벤트 해지
            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}
