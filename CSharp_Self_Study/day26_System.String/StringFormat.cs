using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day26_System.String
{
    class StringFormat
    {
        static void Main()
        {
            string txt = "Hello {0} : {1}";
            string output = string.Format(txt, "World", "Anderson");
            //Console.WriteLine(output);

            string temp = "{2} {0} == {0}: {1}";
            Console.WriteLine(temp, "Hello", "World", "Hi");
        }
    }
}
