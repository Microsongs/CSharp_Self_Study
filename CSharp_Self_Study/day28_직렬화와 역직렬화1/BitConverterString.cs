using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day28_직렬화
{
    class BitConverterString
    {
        static void Main(string[] args)
        {
            //숫자의 직렬화/역직렬화
            byte[] buf = new byte[4];
            buf[0] = 0x4c;
            buf[1] = 0x36;
            buf[2] = 0x19;
            buf[3] = 0x00;

            int result = BitConverter.ToInt32(buf, 0);
            Console.WriteLine(result);
            //숫자->문자의 직렬화/역직렬화
            string text = result.ToString();    //숫자 1652300의 문자열로 직렬화
            result = int.Parse(text);   //문자열로부터 숫자를 역직렬화
            Console.WriteLine(result);
        }
    }
}
