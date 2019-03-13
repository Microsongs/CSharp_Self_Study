using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string msg) : base(msg) { }
    }
    class UserException
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            if(txt != "123")
            {
                InvalidPasswordException ex = new InvalidPasswordException("틀린 암호");
                throw ex;
            }
            Console.WriteLine("올바른 암호");
        }
    }
}
