using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    class stackalloc_Array_heap_to_stack_
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* pArray = stackalloc int[1024];
                pArray[0] = 2020;
                Console.WriteLine(pArray[0]);
            }
        }
    }
}
