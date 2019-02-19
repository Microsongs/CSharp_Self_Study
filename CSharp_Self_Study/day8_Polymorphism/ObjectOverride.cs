using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ToString을 Override해보자!
namespace CSharp_Self_Study.day8_Polymorphism
{
    public class Point
    {
        int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        //Object 클래스의 ToString을 재정의
        public override string ToString()
        {
            return "X : " + x + ", Y : " + y;
        }
    }
    class ObjectOverride
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 5);
            Console.WriteLine(point.ToString());
        }
    }
}
