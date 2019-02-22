using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp_Self_Study.day11_Interface2
{
    class IntegerCompare : IComparer    //ICompaerer를 상속받는 타입 정의
    {
        //IComparer 인터페이스는 Compare 메서드를 구현해야 한다.
        //이 메서드는 Array.Sort 메서드 내에서 콜백으로 호출된다.
        public int Compare(object x,object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;
            if (xValue > yValue)
                return -1;  //내림차순이 되도록 -1 반환
            else if (xValue == yValue)
                return 0;
            return 1;
        }

    }
    class IComparerInterface
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            //ICompare를 상속받은 IntegerCompare 인스턴스 전달
            Array.Sort(intArray, new IntegerCompare()); //메서드가 하나이므로 실행이 된다.
            foreach(int item in intArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
