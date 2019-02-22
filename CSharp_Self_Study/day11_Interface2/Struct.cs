using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day11_Interface2
{
    struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x,int y)  //매개변수를 가진 생성자 정의
        {
            this.X = x; //구조체의 생성자는 구조체가 가진 모든 필드를 초기화해야 한다.
            this.Y = y;
        }
        public override string ToString()   //System.Object의 ToString을 재정의
        {
            return "X: " + X + ", Y = " + Y;
        }
    }
    class Struct
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();   //new를 사용해 인스턴스 생성 가능
            Vector v2;  //new가 없어도 인스턴스 생성 가능
            v2.X = 0;
            v2.Y = 0;
            Vector v3 = new Vector(5, 10);  //명시적으로 생성자 지정 가능
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }
    }
}
