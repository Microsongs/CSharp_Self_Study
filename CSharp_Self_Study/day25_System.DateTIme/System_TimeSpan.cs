using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day25_System.DateTIme
{
    class System_TimeSpan
    {
        static void Main(string[] args)
        {
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime now = DateTime.Now;

            Console.WriteLine("오늘 날짜 : " + now);
            TimeSpan gap = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜 : " + gap.TotalDays);

        }
    }
}
