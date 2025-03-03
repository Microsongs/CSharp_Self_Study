﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Self_Study.day30_Collections
{
    public class Person : IComparable
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
        public int CompareTo(object obj)    //나이 순서대로 정렬
        {
            Person target = obj as Person;
            if (this.Age > target.Age)
                return 1;
            else if (this.Age == target.Age)
                return 0;
            else
                return -1;
        }
        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }
    class ArrayList_Sort_IComparable
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add(new Person(32, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27, "Paul"));

            ar.Sort();

            foreach (Person person in ar)
                Console.WriteLine(person);
        }
    }
}
