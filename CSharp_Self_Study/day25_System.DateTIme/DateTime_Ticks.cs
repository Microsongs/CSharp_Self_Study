﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day25_System.DateTIme
{
    class DateTime_Ticks
    {
        static long Sum()
        {
            long sum = 0;
            for(int i=0; i<1000000; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;

            long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Total Ticks : " + gap);
            Console.WriteLine("Millisecond : " + (gap / 10000));
            Console.WriteLine("Second : " + (gap / 10000 / 1000));
        }
    }
}
