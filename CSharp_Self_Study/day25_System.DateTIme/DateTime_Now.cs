using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day25_System.DateTIme
{
    class DateTime_Now
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime dayForChildren = new DateTime(now.Year, 5, 5);
            Console.WriteLine(dayForChildren);
        }
    }
}
