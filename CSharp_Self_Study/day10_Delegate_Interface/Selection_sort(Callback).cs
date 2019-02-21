using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_
{
    /*
     //기존의 방법
    class SortObject    //배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;
        public SortObject(int[] numbers)    //배열을 생성자의 인자로 보내 보관
        {
            this.numbers = numbers;
        }
        public void Sort()  //Selection SOrt 알고리즘, number 배열의 요소를 크기 순 정렬
        {
            int temp;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                int lowPos = i;
                for(int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[j] > numbers[lowPos])
                    {
                        lowPos = j;
                    }
                }
                temp = numbers[i];
                numbers[i] = numbers[lowPos];
                numbers[lowPos] = temp;
            }
        }
        public void Display()
        {
            foreach(int num in numbers)
            {
                Console.Write(num + ", ");
            }
        }
    }
    */

    //델리게이트 사용 방법
    public delegate bool CompareDelegate(int arg1, int arg2);
    class SortObject    //배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;
        public SortObject(int[] numbers)    //배열을 생성자의 인자로 보내 보관
        {
            this.numbers = numbers;
        }
        public void Sort(CompareDelegate compareMethod)  //Selection SOrt 알고리즘, number 배열의 요소를 크기 순 정렬
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int lowPos = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }
                temp = numbers[i];
                numbers[i] = numbers[lowPos];
                numbers[lowPos] = temp;
            }
        }
        public void Display()
        {
            foreach (int num in numbers)
            {
                Console.Write(num + ", ");
            }
        }
    }

    class Selection_sort_Callback_
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };
            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare);   //오름차순 정렬을 할 수 있는 메서드 전달
            so.Display();

            Console.WriteLine();
            so.Sort(DescendingCompare); //내림차순 정렬을 할 수 있는 메서드 전달
            so.Display();
        }
        public static bool AscendingCompare(int arg1, int arg2)
        {
            return arg1 < arg2;
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return arg1 > arg2;
        }
    }
}
