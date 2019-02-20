using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    class HardDisk
    {
        class Platter
        {

        }
        class Head
        {

        }
        public class Hello
        {

        }
        Platter[] platter;
        Head head;
    }
    class NestedClass
    {
        static void Main(string[] args)
        {
            HardDisk disk = new HardDisk();
            HardDisk.Hello hello = new HardDisk.Hello();    //public으로 되어 있는 내부 클래스에만 접근 가능
        }
    }
}
