using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day23_heap
{
    class GarbageCollectorGeneration0
    {
        static void Main(string[] args)
        {
            GarbageCollectorGeneration0 GBC = new GarbageCollectorGeneration0();
            Console.WriteLine(GC.GetGeneration(GBC));
        }
    }
}
