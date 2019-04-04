using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day29_Stream
{
    [Serializable]
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.Age, this.Name);
        }
    }
    class BinaryFormatterExample
    {
        static void Main(string[] args)
        {
            Person person = new Person(36, "Anderson");
            BinaryFormatter bf = new BinaryFormatter();

            //MemoryStream에 person객체를 직렬화
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, person);

            ms.Position = 0;

            //MemoryStream으로부터 역직렬화하여 복원
            Person clone = bf.Deserialize(ms) as Person;
            Console.WriteLine(clone);
        }
    }
}
