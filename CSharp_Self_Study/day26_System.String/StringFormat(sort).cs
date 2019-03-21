using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day26_System.String
{
    class StringFormat_sort
    {
        static void Main(string[] args)
        {
            string txt = "{0,-10} * {1} == {2,10}";
            Console.WriteLine(txt, 5, 6, 5 * 6);
        }
    }
}
