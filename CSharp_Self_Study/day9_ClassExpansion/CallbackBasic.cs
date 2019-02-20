using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    class Source
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
        public void Do(Source obj)
        {
            Console.WriteLine(obj.GetResult());
        }
    }

    class CallbackBasic //Source 클래스
    {
        static void Main(string[] args)
        {
            Source s = new Source();
            s.Test();
        }
    }
}
