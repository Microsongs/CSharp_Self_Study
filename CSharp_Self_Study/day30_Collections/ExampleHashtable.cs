using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Self_Study.day30_Collections
{
    class ExampleHashtable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            //4개의 요소를 컬렉션에 추가
            ht.Add("key1", "add");
            ht.Add("key2", "remove");
            ht.Add("key3", "update");
            ht.Add("key4", "search");

            //"Key4" 키 값에 해당하는 값을 출력
            Console.WriteLine(ht["key4"]);

            //"key3" 키 값에 해당하는 요소를 컬렉션에서 삭제
            ht.Remove("Key3");

            //"Key2"키 값에 해당하는 값을 delete로 변경
            ht["key2"] = "delete";

            Console.WriteLine();
            //컬렉션의 모든 키 값을 열람하고 그 키에 대응되는 값 출력
            foreach (object key in ht.Keys)
                Console.WriteLine("{0} ==> {1}", key, ht[key]);
        }
    }
}
