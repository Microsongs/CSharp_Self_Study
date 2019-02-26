using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day13_맴버_유형_확장
{
    class IntegerText
    {
        char[] txtNumber;
        public IntegerText(int number)
        {
            //Int32 타입을 System.String으로 변환, 다시 String에서 char 배열로 변환
            this.txtNumber = number.ToString().ToCharArray();
        }
        public char this[int index]
        {
            get
            {
                //1의 자릿수는 숫자에서 가장 마지막 단어를 뜻하므로 역으로 인덱스를 다시 계산
                return txtNumber[txtNumber.Length - index - 1];
            }
            set
            {
                //특정 자릿수를 숫자에 해당하는 문자로 치환 가능
                txtNumber[txtNumber.Length - index - 1] = value;
            }
        }
        public override string ToString()
        {
            return new string(txtNumber);
        }
        public int ToInt32()
        {
            return Int32.Parse(ToString());
        }
    }
    class indexer
    {
        
        static void Main(string[] args)
        {
            IntegerText aInt = new IntegerText(123456);

            int step = 1;
            for(int i=0; i<aInt.ToString().Length; i++)
            {
                Console.WriteLine(step + "의 자릿수 : " + aInt[i]);
                step *= 10;
            }
            aInt[3] = '5';
            Console.WriteLine(aInt.ToInt32());
        }
    }
}
