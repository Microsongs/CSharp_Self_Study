using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class @finally
    {
        static void Main(string[] args)
        {
            int divisor = 0;
            try
            {
                int quotient = 10 / divisor;
                Console.WriteLine("예외가 발생하지 않을 경우 실행");
            }
            catch
            {
                Console.WriteLine("예외가 발생하면 실행됨");
            }
            finally
            {
                Console.WriteLine("언제나 실행됨");
            }
        }
    }
}
