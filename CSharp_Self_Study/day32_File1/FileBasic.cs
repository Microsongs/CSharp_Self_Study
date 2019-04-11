using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day32_File1
{
    class FileBasic
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("Hello WOrld");
                sw.WriteLine("Anderson");
                sw.WriteLine(32000);
                sw.Flush();
            }
        }
    }
}
