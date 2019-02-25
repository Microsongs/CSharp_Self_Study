using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    class Point
    {
        public int X;
        public int Y;
    }
    class ref예약어_CallByReference
    {
        static void Main(string[] args)
        {
            Point pt1 = null;

            Change1(pt1);    //메서드 호출 : 얕은 복사
            Console.WriteLine("ot1 : " + pt1);

            Change2(ref pt1);
            Console.WriteLine("pt1 : X = " + pt1.X + ", y = " + pt1.Y);
        }
        private static void Change1(Point pt)   //얕은 복사
        {
            pt = new Point();
            pt.X = 6;
            pt.Y = 12;
        }
        private static void Change2(ref Point pt)    //ref를 이용한 참조에 의한 호출
        {
            pt = new Point();
            pt.X = 7;
            pt.Y = 14;
        }
    }
}
