using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    class CheckedInfoAttribute : Attribute
    {
        string name;
        public CheckedInfoAttribute(string name) {
            this.name = name;
        }
    }
    [CheckedInfo("checked는 오버플로/언더플로를 막아준다.")]
    class @checked
    {
        static void Main(string[] args)
        {
            //오버플로 상태
            int n = 32768;
            short s = (short)n;
            Console.WriteLine(s);

            short k = 32767;
            //unchecked는 checked와 반대, checked되어있는 상태를 없앤다.
            //checked때문에 k++부분에서 강제적으로 예외처리 발생
            checked
            {
                k++;
            }
            Console.WriteLine(k);
        }
    }
}
