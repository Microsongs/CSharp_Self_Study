using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class throw2
    {
        static void Main(string[] args)
        {
            try
            {
                string txt = null;
                Console.WriteLine(txt.ToUpper());
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
