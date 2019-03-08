using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day18_오류
{
    class DebugAndTraceType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사용자 화면 출력");
            Debug.WriteLine("디버그 화면 출력 - Debug");
            Trace.WriteLine("디버그 화면 출력 - Trace");
        }
    }
}
