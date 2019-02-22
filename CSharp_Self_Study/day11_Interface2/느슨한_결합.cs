using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day11_Interface2
{
    interface IPower
    {
        void TurnOn();
    }
    class Computer : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("전원 온");
        }
    }
    class Switch
    {
        public void PowerOn(IPower ipower)  //IPower를 매개변수로 가져왔으므로 자식 클래스 전부 받을 수 있음
        {
            ipower.TurnOn();
        }
    }
    class 느스한_결합
    {
        static void Main(string[] args)
        {

        }
    }
}
