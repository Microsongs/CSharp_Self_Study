using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Person
    {
        //Constructor
        public Person()
        {
            Console.WriteLine("Hello World");
        }
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}
