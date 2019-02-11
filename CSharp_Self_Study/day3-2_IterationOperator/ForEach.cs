using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day3_2_IterationOperator
{
    class ForEach
    {
        static void Main(string[] args)
        {
            Console.Write("배열 개수 입력 : ");
            int len = int.Parse(Console.ReadLine());

            //배열 생성
            int[] arr = new int[len];
            for(int i = 0; i < len; i++)
            {
                Console.Write("요소 입력 : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //foreach 사용
            foreach(int element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
