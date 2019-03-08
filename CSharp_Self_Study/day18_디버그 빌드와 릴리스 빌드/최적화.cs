using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day18_오류
{
    class 최적화
    {
        static void AccessArray(int[] array)
        {
            array[5] = 0;
        }
        static void Main(string[] args)
        {
            int[] nArray = new int[] { 0, 1, 2, 3, 4 };
            AccessArray(nArray);
        }
    }
}
