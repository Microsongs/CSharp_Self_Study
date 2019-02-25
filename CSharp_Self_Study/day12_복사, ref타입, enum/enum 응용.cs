using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaap_Self_Study.day12_복사__ref타입__enum
{
    enum CalcType { Add, Minus, Multiply, Divide };
    class enum_응용
    {
        public static int Calc(CalcType onType, int oprend1, int oprend2)
        {
            switch (onType)
            {
                case CalcType.Add : return oprend1 + oprend2;
                case CalcType.Minus: return oprend1 - oprend2;
                case CalcType.Multiply: return oprend1 * oprend2;
                case CalcType.Divide: return oprend1 / oprend2;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(CalcType.Add, 5, 6));    //enum 인스턴스 메서드로 전달
        }
    }
}
