using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day17_프로젝트_구성.다중_소스코드V1
{
    [Obsolete("이 클래스는 다음 버전에서 없어질 예정임. NewType을 사용한다.")]
    class OldType { }

    class NewTYpe { }
    class ObsoleteTest
    {
        static void Main(string[] args)
        {
            OldType my = new OldType();
        }
    }
}
