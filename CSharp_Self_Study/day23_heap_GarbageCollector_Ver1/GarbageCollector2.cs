using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day23_heap
{
    class GarbageCollector2
    {
        static void Main(string[] args)
        {
            object a = new object();
            object b = new object();
            object c = new object();

            DoMethod();
            GC.Collect();
        }
        static void DoMethod()
        {
            object d = new object();
            object e = new object();

            object f = new object();
            object g = new object();

            d = null;
            e = null;

            GC.Collect();

            object h = new object();
            object i = new object();

            object j = new object();
            object k = new object();

            j = null;
            k = null;
            GC.Collect();
        }
    }
}
