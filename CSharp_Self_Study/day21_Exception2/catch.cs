using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class @catch
    {
        static void Main(string[] args)
        {
            int divisor = 0;
            string txt = null;
            try
            {
                Console.WriteLine(txt.ToUpper());   //System.NullReferenceException 예외 발생
                int quotient = 10 / divisor;
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
