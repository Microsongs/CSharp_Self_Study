using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day34_File3
{
    class 기타
    {
        static void Main(string[] args)
        {
            string samplePath = @"C:\temp\bin\Debug\app.exe";

            Console.WriteLine("ChangeExtension ==> " + Path.ChangeExtension(samplePath, ".dll"));
            Console.WriteLine("GetDirectoryName ==> " + Path.GetDirectoryName(samplePath));
            Console.WriteLine("GetFullPath ==> " + Path.GetFullPath(samplePath));
            Console.WriteLine("GetFileName ==> " + Path.GetFileName(samplePath));
            Console.WriteLine("GetFileNameWithoutExtension ==> " + Path.GetFileNameWithoutExtension(samplePath));
            Console.WriteLine("GetExtension ==> " + Path.GetExtension(samplePath));
            Console.WriteLine("GetPathRoot ==> " + Path.GetPathRoot(samplePath));
        }
    }
}
