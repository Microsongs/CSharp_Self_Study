using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day21_Exception2
{
    class Stack_Trace
    {
        static void Main(string[] args)
        {
            //호출 스택은 디버그 모드로 빌드해야 한다.
            HasNoProblem();

            HasProblem();   //NullReferenceException 발생
        }
        private static void HasNoProblem()
        {
            WriteText("Argument is not NULL");
        }
        private static void HasProblem()
        {
            WriteText(null);    //NullReferenceException 발생
        }
        private static void WriteText(string txt)
        {
            Console.WriteLine(txt.ToLower());
        }
    }
}
