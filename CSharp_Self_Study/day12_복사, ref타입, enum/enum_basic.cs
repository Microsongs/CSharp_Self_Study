using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday,Thursday , Friday, Saturday
    }
    class enum_basic
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Tuesday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days, Sunday));   //sunday의 포함 여부
            Days today = Days.Friday;
            Console.WriteLine(workingDays, HasFlag(today)); //today를 퐇마하고 있는가

            Console.WriteLine(workingDays);
        }
    }
}
