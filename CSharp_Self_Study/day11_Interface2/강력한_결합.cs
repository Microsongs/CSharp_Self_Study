using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day11_Interface2
{
    class Computer  //Computer를 모니터로 바꾸면 Switch의 변수이름까지 변경해야 한다.
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor : TurnOn");
        }
    }

    class Switch
    {
        public void PowerOn(Computer machine)    //Computer를 Monitor로 교체
        {
            machine.TurnOn();
        }
    }
    class 강력한_결합
    {
        static void Main(string[] args)
        {
            
        }
    }
}
