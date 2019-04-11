using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day33_File
{
    class ExampleFileInfo
    {
        static void Main(string[] args)
        {
            FileInfo source = new FileInfo("test.log");
            FileInfo target = new FileInfo("C:\\temp\\test.dat");

            if (target.Exists == true)
                target.Delete();
            source.MoveTo(target.FullName);
        }
    }
}
