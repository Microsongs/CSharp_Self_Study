using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day1_Variable
{
    class Variable1
    {
        static void Main(String[] args)
        {
            int n1 = 50;    //선언과 동시에 값 부여
            int n2;         //선언
            n2 = 100;       //이후 값 부여

            long sum = n1 + n2; //더한 값을 저장

            Console.WriteLine(sum); //출력 결과 : 150

            //위는 아래와 같이 바꿀 수 있다.(닷넷 프레임워크 형식)
            System.Int32 n3 = 50;
            System.Int32 n4;
            n4 = 100;

            System.Int32 sum2 = n3 + n4;
            Console.WriteLine(sum2);    //결과 : 150
        }
    }
}
