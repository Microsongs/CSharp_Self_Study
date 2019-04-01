using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day28_직렬화
{
    class BitConverterExample
    {
        static void Main(string[] args)
        {
            //기본 타입을 바이트 배열로 변환
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);
            //바이트 배열을 기본 타입으로 변환
            bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
            short ShortREsult = BitConverter.ToInt16(shortBytes, 0);
            int intResult = BitConverter.ToInt32(intBytes, 0);
            //바이트 배열을 출력
            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));
        }
    }
}
