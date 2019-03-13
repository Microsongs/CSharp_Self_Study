using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class ExceptionCase
    {
        bool LogText(string txt)
        {
            if (txt == null)
                return false;
            Console.WriteLine(txt.ToUpper());
            return true;    //정상 동작을 하였을 경우 true 반환
        }
        void LogTextWithException(string txt)
        {
            if (txt == null) //txt인자가 null이면 안되므로 예외 발생
                throw new ArgumentNullException("txt");
            Console.WriteLine(txt.ToUpper());
        }
    }
}
