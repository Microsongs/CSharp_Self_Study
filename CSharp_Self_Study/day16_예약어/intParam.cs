using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    [AttributeUsage(AttributeTargets.Method)]
    class AddInfoAttribute : Attribute
    {
        string info;
        public AddInfoAttribute(string info)
        {
            this.info = info;
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
    }
    class ParamInfoAttribute : Attribute
    {
        string info;
        public ParamInfoAttribute(string info)
        {
            this.info = info;
        }
    }
    [ParamInfo("Param은 매개변수의 개수를 모를 떄 사용하는 가변 매개변수이다.")]
    class intParam
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
        [method:AddInfo("이 함수는 param을 사용하여 덧셈하는 메서드")]
        static int Add(params int[] value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result += value[i];
            }
            return result;
        }
    }
}
