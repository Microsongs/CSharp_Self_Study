using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day13_맴버_유형_확장
{
    public class Point
    {
        readonly int x, y;
        public int X {
            get { return x; }
            //set { x = value; }
        }
        public int Y { get { return y; } }

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class @readonly
    {
        static void Main(string[] args)
        {
            Point pt = new Point(5, 10);
            Point pt2 = new Point(pt.X + 1, pt.Y + 1);
        }
    }
}
