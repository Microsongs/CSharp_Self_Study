using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

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
    class DataContractJsonSerializerExample
    {
        static void Main(string[] args)
        {
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Person));
            MemoryStream ms = new MemoryStream();

            Person person = new Person(36, "Anderson");

            //MemoryStream에 문자열로 person객체를 직렬화
            dcjs.WriteObject(ms, person);

            ms.Position = 0;

            //MemoryStream으로부터 객체를 역직렬화해서 복원
            Person clone = dcjs.ReadObject(ms) as Person;

            //Console.WriteLine(clone);   //출력 결과 : 36 Anderson

            //장점 확인
            byte[] buf = ms.ToArray();
            Console.WriteLine(Encoding.UTF8.GetString(buf));
        }
    }
}
