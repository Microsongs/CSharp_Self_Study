#define DEBUG1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Self_Study.day18_오류
{
    class ConditionalDebug
    {
        static void Main(string[] args)
        {
            OutputText();
        }
        
        [Conditional("DEBUG")]
        static void OutputText()
        {
            Console.WriteLine("디버그 빌드");
        }
    }
}
