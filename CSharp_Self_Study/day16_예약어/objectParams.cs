using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class InfoAttribute : Attribute
    {
        string infomation;
        public InfoAttribute(string infomation)
        {
            this.infomation = infomation;
        }
    }
    [Info("이 클래스는 objectParams를 받을 수 있는 것을 보여주는 예제")]
    class objectParams
    {
        [Info("메인 함수")]
        static void Main(string[] args)
        {
            PrintAll(1.05, "Result", 3);
        }
        [Info("object를 매개변수로 받는 params")]
        static void PrintAll(params object[] values)
        {
            foreach(object value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
