using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day4_Object_Oriented
{
    class Mathematics
    {
        public int GetAreaOfSquare(int x)
        {
            return x * x;
        }
        public int GetValue()   //매개변수 없이 값만 반환
        {
            return 10;
        }
        // 2개의 매개변수를 받고, 반환값이 없다.
        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }
    class useMethod2
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaOfSquare(m.GetValue());

            m.Output("결과 : ", result);
        }
    }
}
