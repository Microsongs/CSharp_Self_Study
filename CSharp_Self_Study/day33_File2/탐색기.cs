using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day33_File
{
    class 탐색기
    {
        static void Main(string[] args)
        {
            // 1. 컴퓨터의 모든 디스크 드라이브를 나열한다.
            foreach (string txt in Directory.GetLogicalDrives())
                Console.WriteLine(txt);

            // 2. 특정 폴더의 파일 목록을 나열한다.
            string targetPath = @"C:\\Windows\Microsoft.Net\Framework";
            foreach (string txt in Directory.GetFiles(targetPath))
                Console.WriteLine(txt);

            // 3. 특정 폴더의 디렉토리 목록을 나열한다.
            string targetPath2 = @"C:\\Windows\Microsoft.Net\Framework";
            foreach (string txt in Directory.GetDirectories(targetPath2))
                Console.WriteLine(txt);

            // 4. 특정 폴더 및 그 폴더의 모든 하위 폴더를 검색해서 파일을 찾는다.
            string targetPath3 = @"C:\\Windows\Microsoft.Net\Framework";
            foreach (string txt in Directory.GetFiles(targetPath3, "*.exe", SearchOption.AllDirectories))
                Console.WriteLine(txt);

        }
    }
}
