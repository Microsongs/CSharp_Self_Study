using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_if_while_for
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int value = int.Parse(Console.ReadLine());

            //if문 사용
            Console.WriteLine("if문 사용 결과");
            if (value % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");

            //삼항연산자 사용
            Console.WriteLine("\n삼항 연산자 사용 결과");
            string result = (value % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
