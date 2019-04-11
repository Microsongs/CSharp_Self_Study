using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day33_File
{
    class FileExample
    {
        static void Main()
        {
            //Copy 메서드
            //경로가 지정되지 않으면 Environment.CurrentDirectory가 기본 경로로 사용
            //대상 폴더에 파일이 있다면
            File.Copy("test.log", "test.dat");

            //대상 폴더에 파일이 있고, 덮어 쓸 의도라면
            File.Copy("test.log", "test.dat", true);

            //Move메서드
            //폴더가 동일하다면 파일명 변경
            File.Move("test.log", "test.dat");

            //폴더가 다르다면 파일 이동
            File.Move("test.log", "C:\\temp\\test.dat");

            //Move 메서드의 덮어쓰기 구현
            string target = "C\\temp\\test.dat";
            if (File.Exists(target) == true)
                File.Delete(target);
            File.Move("test.log", target);

            //파일의 내용을 한번에 읽고 쓰는 메서드
            string text = new string('c', 20);  //문자 c를 20개 반복한 문자열 생성
            File.WriteAllText("test.log", text);

            string clone = File.ReadAllText("test.log");
            Console.WriteLine(clone);


        }
    }
}
