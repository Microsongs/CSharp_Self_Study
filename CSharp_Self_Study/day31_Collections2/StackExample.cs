using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day31_Collections2
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push(1);
            st.Push(5);
            st.Push(3);

            int Last = (int)st.Pop();
            st.Push(7);

            while (st.Count > 0)
                Console.Write(st.Pop() + ", ");
            //stack을 Pop없이 비울 경우 st.Clear 메서드 사용
        }
    }
}
