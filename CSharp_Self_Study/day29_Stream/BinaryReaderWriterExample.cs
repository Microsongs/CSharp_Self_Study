using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day29_Stream
{
    class BinaryReaderWriterExample
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();

            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write("Hello World" + Environment.NewLine);
            bw.Write("Anderson" + Environment.NewLine);
            bw.Write(32500);
            bw.Flush();

            ms.Position = 0;

            BinaryReader br = new BinaryReader(ms);
            string first = br.ReadString();
            string second = br.ReadString();
            int result = br.ReadInt32();

            Console.WriteLine("{0}{1}{2}", first, second, result);
        }
    }
}
