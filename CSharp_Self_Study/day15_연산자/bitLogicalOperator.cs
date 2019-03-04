using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day15_연산자
{
    //저번 시간 반복
    class BitLogicalOperatorInfo : Attribute
    {
        string name;
        public BitLogicalOperatorInfo(string name)
        {
            this.name = name;
        }
    }
    //아래와 같은 방법은 보통 Flag 특성이 지정된 enum 타입으로 대체하는 것이 일반적
    [BitLogicalOperatorInfo("비트 논리 연산자 연습")]
    class bitLogicalOperator
    {
        static void Main(string[] args)
        {
            Calc(0x01, 10, 5);  //더하기만 수행
            Calc(0x02 | 0x04 | 0x08, 10, 5);    //빼기, 곱하기, 나누기를 함께 수행
        }
        private static void Calc(int op,int operand1, int operand2)
        {
            if ((op & 0x01) == 0x01) //비트 1 : 더하기
                Console.WriteLine(operand1 + operand2);

            if ((op & 0x02) == 0x02) //비트 02 : 빼기
                Console.WriteLine(operand1 - operand2);

            if ((op & 0x04) == 0x04) //비트 03 : 곱하기
                Console.WriteLine(operand1 * operand2);

            if ((op & 0x08) == 0x08) //비트 04 : 나누기
                Console.WriteLine(operand1 / operand2);
        }
    }
}
