using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day24_GarbageCollector2
{
    class FreeResource
    {
        static void Main(string[] args)
        {
            FileCreate();

            Console.WriteLine("파일이 열려 있습니다.");
            Console.ReadLine();
        }
        static void FileCreate()
        {
            FileStream fs = new FileStream("output.log", FileMode.Create);
        }
    }
}
