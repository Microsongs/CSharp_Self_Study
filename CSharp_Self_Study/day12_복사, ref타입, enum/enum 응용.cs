using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaap_Self_Study.day12_복사__ref타입__enum
{
    public static int Calc(char onType, int oprend1, int oprend2)
    {
        switch (onType)
        {
            case '+': return oprend1 + oprend2;
            case '-': return oprend1 - oprend2;
            case '*': return oprend1 * oprend2;
            case '/': return oprend1 / oprend2;
        }
        return 0;
    }
    class enum_응용
    {
        static void Main(string[] args)
        {

        }
    }
}
