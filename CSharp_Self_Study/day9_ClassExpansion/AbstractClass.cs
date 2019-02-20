using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day9_ClassExpansion
{
    class Point
    {
        int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x : " + x + ", y : " + y;
        }
    }

    abstract class DrawingObject    //추상 클래스
    {
        public abstract void Draw();    //추상 메서드(코드 없는 가상 메서드0
        public void Move()   //일반 메서드도 정의 가능
        {
            Console.WriteLine("Move"); 
        }
    }
    class Line : DrawingObject  //추상 클래스를 상속받는 Line 클래스
    {
        Point pt1, pt2;
        public Line(Point pt1, Point pt2)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
        }
        public override void Draw() //추상클래스의 추상 메서드는 반드시 정의해야 한다.
        {
            Console.WriteLine("Line " + pt1.ToString() + " ~ " + pt2.ToString());
        }
    }

    class AbstractClass
    {
        static void Main(string[] args)
        {
            DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));
            line.Draw();    //다형성에 따라 Line.Draw 호출
        }
    }
}
