using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    class out예약어_여러반환값
    {
        static bool divide(int n1, int n2, out int result)
        {
            if(n2 == 0)
            {
                result = 0;
                return false;
            }
            result = n1 / n2;
            return true;
        }

        static void Main(string[] args)
        {

        }
    }
}
