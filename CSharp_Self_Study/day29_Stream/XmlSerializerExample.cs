using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Self_Study.day29_Stream
{
    public class Person
    {
        public int Age;
        public string Name;
        public Person()
        {

        }

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
    class XmlSerializerExample
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            Person person = new Person(36, "Anderson");

            //MemoryStream에 문자열로 person객체를 직렬화
            xs.Serialize(ms, person);

            ms.Position = 0;

            //MemoryStream로부터 객체를 역직렬화해서 복원
            Person clone = xs.Deserialize(ms) as Person;

            //Console.WriteLine(clone);

            byte[] buf = ms.ToArray();
            Console.WriteLine(Encoding.UTF8.GetString(buf));
        }
    }
}
