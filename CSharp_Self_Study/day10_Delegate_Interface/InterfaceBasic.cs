using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_Delegate_Interface
{
    interface IMonitor
    {
        void TurnOn();
        int Inch { get; set; }  //프로퍼티 get/set 포함
        int Width{ get; }   //하나만 포함 가능
    }
    class Notebook : IMonitor
    {
        public void TurnOn() { }
        int inch;
        public int Inch
        {
            get { return inch; }
            set { inch = value; }
        }
        int width;
        public int Width { get { return width; } }
    }

    class InterfaceBasic
    {
    }
}
