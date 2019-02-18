using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    public class Computer
    {
        bool powerOn;
        public void Bot() { }
        public void Shutdown()
        {
            Console.WriteLine("Shutdown");
        }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice()
        {
            return fingerScan;
        }
        public void CloseLid()
        {
            base.Shutdown();    //baase 예약어를 명시, 부모의 Shutdown을 호출한다.
        }
    }
    class Base_Example
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.CloseLid();
        }
    }
}
