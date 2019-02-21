using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_
{
    delegate bool CompareDelegate(object arg1, object arg2);    //딜리게이트 선언
    delegate object typeDelegate(object arg1);
    class Person
    {
        string name;
        int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(int age, string name)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return name + ": " + age;
        }
    }
    //sort클래스가 person 종속적이지 않도록
    class SortObject
    {
        object[] things;
        public SortObject(object[] things)
        {
            this.things = things;
        }

        public void Sort(CompareDelegate compareMethod)
        {
            object temp;
            for(int i=0;i<things.Length; i++)
            {
                int lowPos = i;
                for(int j=i+1; j<things.Length; j++)
                {
                    if (compareMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }
                }
                temp = things[i];
                things[i] = things[lowPos];
                things[lowPos] = temp;
            }
        }
        public void Display()
        {
            for(int i=0;i<things.Length; i++)
            {
                Console.WriteLine(things[i]);
            }
        }
    }
    class Callback_Delegate2_Upgrade
    {
        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;
            Person person2 = arg2 as Person;

            return person1.Name.CompareTo(person2.Name) < 0;
        }
        static bool IntAscSortByName(object arg1, object arg2)
        {
            int n1 = (int)arg1;
            int n2 = (int)arg2;
            return n1 < n2;
        }
        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(51,"Anders"),
                new Person(37,"Scott"),
                new Person(45,"Peter"),
                new Person(62,"Mads"),
            };
            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();
        }
    }
}
