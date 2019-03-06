using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day17_프로젝트_구성.다중_소스코드V1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter logwriter = new LogWriter();
            logwriter.Write("start");
        }
    }
}
