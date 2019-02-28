using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CSharp_Self_Study.day14_구문
{
    class MarshalAs_Attribute
    {
        //아래는 field, param, return 선언에만 사용할 수 있는데, 특성이 적용된 코드가 Main 메서드이므로 자동으로
        //[method:MarshalAs(....)]으로 지정된다.
        //[MarshalAs(UnmanagedType.I4)]
        [return:MarshalAs(UnmanagedType.I4)]
        static int Main(string[] args)
        {
            return 0;
        }
    }
}
