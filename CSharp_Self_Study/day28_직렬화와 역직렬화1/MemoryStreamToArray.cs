﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day28_직렬화
{
    class MemoryStreamToArray
    {
        static void Main(string[] args)
        {
            //short와 int 데이터를 순서대로 MemoryStream에 직렬화
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);
            MemoryStream ms = new MemoryStream();
            ms.Write(shortBytes, 0, shortBytes.Length);
            ms.Write(intBytes, 0, intBytes.Length);

            byte[] buf = ms.ToArray();  //MemoryStream에 담긴 바이트 배열 반환

            //바이트 배열로부터 short 데이터를 역직렬화
            int shortResult = BitConverter.ToInt16(buf, 0);
            Console.WriteLine(shortResult); //출력 결과 : 32000
            //이어서 int 데이터를 역직렬화
            int intResult = BitConverter.ToInt32(buf, 2);
            Console.WriteLine(intResult);   //출력 결과 : 1652300
        }
    }
}
