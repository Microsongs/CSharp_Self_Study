using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day34_File3
{
    class 임시_폴더
    {
        static void Main(string[] args)
        {
            //크기가 0인 임시 파일을 생성하고 그 경로를 반환
            string createTempFilePath = Path.GetTempFileName();
            Console.WriteLine(createTempFilePath);

            //임시 파일을 생성하지 않고 중복될 확률이 낮은 임시 파일 경로를 구한다.
            string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Console.WriteLine(tempFilePath);


        }
    }
}
