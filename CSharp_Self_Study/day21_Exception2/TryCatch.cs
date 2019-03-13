using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            int divisor = 0;
            try
            {
                int quotient = 10 / divisor;
            }
            catch { }
        }
    }
}
