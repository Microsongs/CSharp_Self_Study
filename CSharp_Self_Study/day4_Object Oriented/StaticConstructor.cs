using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string _name;

    public Person(string name)
    {
        _name = name;
        Console.WriteLine("ctor 실행");
    }
    static Person()
    {
        Console.WriteLine("cctor 실행");
    }
}

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class StaticConstructor
    {
        static void Main(string[] args){
            Person person1 = new Person("");
            Console.WriteLine("---------");
            Person perosn2 = new Person("");
        }
    }
}
