using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    class GetType
    {
        static void Main(string[] args)
        {
            //일반적 사용법
            int n = 5;
            string txt = "text";
            Type intType = n.GetType();
            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType());

            Type type = typeof(double);
            Console.WriteLine(type.GetType());
            Console.WriteLine(type.FullName);
            Console.WriteLine(typeof(System.Int16));
        }
    }
}
