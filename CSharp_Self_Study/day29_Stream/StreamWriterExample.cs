using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day29_Stream
{
    class StreamWriterExample
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();

            StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
            sw.WriteLine("Hello World");
            sw.WriteLine("Anderson");
            sw.Write(32000);
            sw.Flush();

            ms.Position = 0;

            StreamReader sr = new StreamReader(ms, Encoding.UTF8);
            string txt = sr.ReadToEnd();
            Console.WriteLine(txt);
        }
    }
}
