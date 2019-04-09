using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day32_File1
{
    class FileLogging
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("test.log", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Hello World");
                Console.ReadLine();
            }
        }
    }
}
