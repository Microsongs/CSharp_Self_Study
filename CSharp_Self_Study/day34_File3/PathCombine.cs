using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day34_File3
{
    class PathCombine
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(@"C:\temp", "test", "myfile.dat");
            Console.WriteLine(filePath);   
        }
    }
}
