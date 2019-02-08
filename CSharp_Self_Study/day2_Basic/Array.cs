using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day2_Basic
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] products = new int[5];    //5칸의 products 배열 생성
            products[0] = 100;
            products[1] = 200;

            int book = products[0];
            int sum = products[0] + products[1];
            Console.WriteLine(book + "\n" + sum);

            //배열의 초기화 방법
            int[] product1 = new int[5] { 1, 2, 3, 4, 5 };  //배열의 개수를 정하고 초기화

            int[] product2 = new int[] { 1, 2, 3, 4, 5 };   //배열의 개수 요소를 미지정, 본 예제와 같은 경우에는 5칸 생성
        }
    }
}
