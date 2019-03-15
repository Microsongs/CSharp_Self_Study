using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day23_heap
{
    class GarbageCollector
    {
        static void Main(string[] args)
        {
            object pg = new object();   //가비지 수집을 위한 임시 객체
            Console.WriteLine(GC.GetGeneration(pg));    //출력 결과 : 0

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));    //출력 결과 : 1    

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));    //출력 결과 : 2

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(pg));    //출력 결과 : 2  
        }
    }
}
