using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day27_System.Text.StringBuilder
{
    class EncodingExample
    {
        static void Main(string[] args)
        {
            string textData = "Hello World";

            byte[] buf = Encoding.UTF8.GetBytes(textData);
            //buf 바이트 배열을 자바 프로그램에 전달
            //자바 프로그램으로부터 전달받은 바이트 배열 데이터
            byte[] received = buf;
            string data = Encoding.UTF8.GetString(received);
        }
    }
}
