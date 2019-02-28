using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day14_구문
{
    class 전처리기1
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            if(string.IsNullOrEmpty(txt) == false)
            {
                Console.WriteLine("사용자 입력 : " + txt);
            }
    #if OUTPUT_LOG
            else
            {
                Console.WriteLine("입력되지 않음");
            }
    #endif
        }
    }
}
