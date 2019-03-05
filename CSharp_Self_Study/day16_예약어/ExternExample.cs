using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CSharp_Self_Study.day16_예약어
{
    class ExternExample
    {
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);
        static int TestMethod(uint type)    //위의 메서드와 비교를 위한 정적 메서드
        {
            return 0;
        }
        static void Main(string[] args)
        {
            MessageBeep(0);
        }
    }
}
