using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day16_예약어
{
    [AttributeUsage(AttributeTargets.Method)]
    class unsafeInfoAttribute : Attribute
    {
        string info;
        public unsafeInfoAttribute(string info)
        {
            this.info = info;
        }
    }
    //unsafe를 사용할 경우 무조건 /unsafe를 사용하여 컴파일해야 한다.
    class unsafe_C_and_C___s_Pointer_
    {
        [unsafeInfo("포인터의 연산자(*, &)를 사용하는 경우 unsafe로 무조건 감써야함")]
        unsafe static void GetAddResult(int *p, int a, int b)
        {
            *p = a + b;
        }

        static void Main(string[] args)
        {
            int i;
            unsafe
            {
                GetAddResult(&i, 5, 10);
            }
            Console.WriteLine(i);
        }
    }
}
