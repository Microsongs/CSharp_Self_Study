using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day12_복사__ref타입__enum
{
    struct Vector
    {
        public int x;
        public int y;
    }
    class Point
    {
        public int X;
        public int Y;
    }
    class deep_shallow1
    {
        static void Main(string[] args)
        {
            Vector v1;
            v1.x = 5;
            v1.y = 10;

            Vector v2 = v1; //값 형식의 대입
            Point pt1 = new Point();
            pt1.X = 6;
            pt1.Y = 12;
            Point ppt2 = pt1;   //참조 형식의 대입
        }
    }
}
