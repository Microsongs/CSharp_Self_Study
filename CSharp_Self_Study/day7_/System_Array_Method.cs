using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    class System_Array_Method
    {
        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);    //Rank 프로퍼티
            Console.WriteLine("배열의 요소 수 : " + arr.Length);  //Length 프로퍼티
            Console.WriteLine();
        }

        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr.GetValue(i) + ",");   //GetValue 인스턴스 메서드
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray);   //Sort 정적 메서드
            OutputArrayElements("Array sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);   //Copy 정적 메서드
            OutputArrayElements("intArray로붜 복사된 copyArray", copyArray);
        }
    }
}
