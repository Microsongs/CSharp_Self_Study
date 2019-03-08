using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day18_오류
{
    class DEBUG
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("디버그 빌드");
#endif
        }
    }
}
