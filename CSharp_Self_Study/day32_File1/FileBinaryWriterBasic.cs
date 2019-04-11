using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day32_File1
{
    class FileBinaryWriterBasic
    {
        static void Main(string[] args)
        {
            using(FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Hello World" + Environment.NewLine);
                bw.Write("Anderson" + Environment.NewLine);
                bw.Write(32000);
                bw.Flush();
            }
        }
    }
}
