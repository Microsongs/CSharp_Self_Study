using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day34_File3
{
    class GetInvalid
    {
        static void Main(string[] args)
        {
            string newDirName = "my<new";
            int include = newDirName.IndexOfAny(Path.GetInvalidPathChars());

            if (include != -1)
                Console.WriteLine("폴더명에 적절하지 않은 문자가 있음");
        }
    }
}
