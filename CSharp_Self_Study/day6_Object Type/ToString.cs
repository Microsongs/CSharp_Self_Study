using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    class Program
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Program(string name)
        {
            this.name = name;
        }
    }
    class ToString
    {
        static void Main(string[] args)
        {
            // 참조형 변수의 ToString
            ToString tostring = new ToString();
            Console.WriteLine(tostring.ToString());
            Console.WriteLine(new Program("안녕").ToString());
            Console.WriteLine(new Program("안녕").Name.ToString());

            // 값 변수의 ToString
            int n = 500;
            double d = 3.1415926535897932384626;
            string txt = "hello : ";
            Console.WriteLine(txt + n.ToString());
            Console.WriteLine(txt + d.ToString());
            txt = d.ToString();
            Console.WriteLine(txt);
        }
    }
}
