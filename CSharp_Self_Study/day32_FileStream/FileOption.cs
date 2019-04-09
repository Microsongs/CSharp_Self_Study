using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day32_File1
{
    class FileOption
    {
        static void Main(string[] args)
        {
            //로깅 목적의 파일 열기
            using (FileStream fs = new FileStream("....", FileMode.Append))
            {
                //쓰기 작업
            }

            //전용 데이터 입/출력
            using (FileStream fs = new FileStream("....",FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                //읽기/쓰기 작업
            }

            //읽기 데이터 입/출력
            using (FileStream fs = new FileStream("....",FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                //읽기 쓰기 작업
            }
        }
    }
}
