using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day10_Delegate_Interface
{
    interface ISource
    {
        int GetResult();    //콜백용으로 사용될 메서드를 인터페이스로 분리
    }
    class Source : ISource
    {
        public int GetResult()
        {
            return 10;
        }
        public void Test()
        {
            Target target = new Target();
            target.Do(this);
        }
    }
    class Target
    {
        public void Do(ISource obj) //ISource 인터페이스를 받는다.
        {
            Console.WriteLine(obj.GetResult()); //콜백 메서드 호출
        }
    }

    class InterfaceCallback
    {
        static void Main(string[] args)
        {
            Source source = new Source();
            source.Test();

        }
    }
}
