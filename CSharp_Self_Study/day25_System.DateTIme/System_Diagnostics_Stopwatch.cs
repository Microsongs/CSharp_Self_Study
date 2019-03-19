using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Self_Study.day25_System.DateTIme
{
    class System_Diagnostics_Stopwatch
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            st.Start();
            Sum();
            st.Stop();

            Console.WriteLine("total Ticks : " + st.ElapsedTicks);
            Console.WriteLine("Millisecond : " + (st.ElapsedMilliseconds));
            Console.WriteLine("Second : " + st.Elapsed.Milliseconds / 1000);

        }
        static void Sum()
        {
            int Sum = 0;
            for(int i=0; i<1000000; i++)
            {
                Sum += i;
            }
        }
    }
}
