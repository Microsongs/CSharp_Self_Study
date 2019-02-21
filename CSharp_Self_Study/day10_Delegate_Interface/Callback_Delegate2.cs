using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_
{
    //델리게이트
    delegate bool CompareDelegate(Person arg1, Person arg2);
    class Person
    {
        int age;
        string name;
           
        public int Age
        {
            get { return age; }
            set { Age = value; }
        }
        public string Name
        {
            get { return name; }
            set { Name = value; }
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }
    class SortPerson
    {
        Person[] men;
        
        public SortPerson(Person[] men)
        {
            this.men = men;
        }
        public void Sort(CompareDelegate compareMethod) //비교를 위한 delegate 인자
        {
            Person temp;
            for(int i=0; i<men.Length; i++)
            {
                int lowPos = i;
                for(int j=i+1; j<men.Length; j++)
                {
                    if(compareMethod(men[j],men[lowPos]))
                    {
                        lowPos = j;
                    }
                }
                temp = men[i];
                men[i] = men[lowPos];
                men[lowPos] = temp;
            }
        }

        public void Display()
        {
            foreach(Person p in men)
            {
                Console.WriteLine(p + ",");
            }
        }
    }

    class Callback_Delegate2
    {
        static bool AscSortByName(Person arg1, Person arg2)
        {
            //string 객체의 CompareTo메서드는 문자열 비교를 수행
            //문자열이 사전 정렬 순으로 비교해서 크면 1, 같으면 0, 작으면 -1 반환
            //따라서 0보다 작은 값을 반환할 경우 rue로 가정하면 오름차순
            return arg1.Name.CompareTo(arg2.Name) < 0;
        }
        static bool DecSortByName(Person arg1, Person arg2)
        {
            return arg1.Name.CompareTo(arg2.Name) > 0;
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

            SortPerson so = new SortPerson(personArray);
            so.Sort(AscSortByName);
            so.Display();

            Console.WriteLine();

            so.Sort(DecSortByName);
            so.Display();
        }
    }
}
