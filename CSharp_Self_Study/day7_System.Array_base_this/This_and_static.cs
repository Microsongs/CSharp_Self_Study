using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    class Book
    {
        string title;  //인스턴스 필드
        static int count;   //정적 필드

        public Book(string title)
        {
            this.title = title; //this로 인스턴스 필드 식별 가능
            this.Open();    //this로 인스턴스 메서드 식별 가능
            Increment();    //정적 메서드 사용 가능
        }

        public void Open() //instance 메서드
        {
            Console.WriteLine(this.title);  //인스턴스 멤버 사용 가능
            Console.WriteLine(count);   //정적 멤버 사용 가능
        }

        public void Close()
        {
            Console.WriteLine(this.title + " 책을 덮는다.");
        }

        public static void Increment()  //정적 메서드
        {
            count++;    //정적 필드 사용 가능
                        //정적 메서드에는 this가 없으므로 인스턴스 맴버 사용 불가능
        }
    }
    class This_and_static
    {
        static void Main(string[] args)
        {

        }
    }
}
