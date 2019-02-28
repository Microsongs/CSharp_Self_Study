#define __X86__
#undef OUTPUT_LOG   //전처리기 지시자는 파일의 맨 앞에

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day14_구문
{
    class 전처리기2
    {  
        static void Main(string[] args)
        {
#if OUTPUT_LOG
            Console.WriteLine("OUTPUT_LOG가 정의됨");
#else
            Console.WriteLine("OUTPUT_LOG가 정의 안 됨");
#endif

#if __X86__
            Console.WriteLine("__X86__ 정의됨");
#elif __X64__
            Console.WriteLIne("__X64__ 정의됨");
#else
            Console.WriteLine("아무 것도 정의 안됨");
#endif
        }
    }
}
