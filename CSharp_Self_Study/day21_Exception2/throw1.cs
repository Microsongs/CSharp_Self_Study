using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class throw1
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            if(txt != "123")
            {
                ApplicationException ex = new ApplicationException("틀린 암호");
                //강제 예외 발생
                throw ex;
            }
            Console.WriteLine("올바른 암호");
        }
    }
}
