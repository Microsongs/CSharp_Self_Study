using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    delegate int GetREsultDelegate();   //int를 반환하고 매개변수가 없는 Delegate타입 정의
    class Target
    {
        public void Do(GetREsultDelegate getResult)
        {
            Console.WriteLine(getResult()); //Callback 메서드 호출
        }
    }
    class Source
    {
        public int GetResult()  //callback 용도로 전달될 메서드
        {
            return 10;
        }
        public void Test()
        {
            Target target = new Target();
            target.Do(new GetREsultDelegate(this.GetResult));
        }
    }
    class CallbackDelegate
    {
        static void Main(string[] args)
        {
            Source s = new Source();
            s.Test();
        }
    }
}
