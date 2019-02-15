using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    public class Computer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class ObjectType
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            object obj1 = computer;
            Computer pc1 = obj1 as Computer;
            pc1.Name = "마이크로송";
            Console.WriteLine(pc1.Name);
        }
    }
}
