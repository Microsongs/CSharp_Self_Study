using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Equals를 Override해보자!
//GetHashCode도 Override해보자!
namespace CSharp_Self_Study.day8_Polymorphism
{
    class Book
    {
        decimal isbn13;
        string title;
        string contents;

        public Book(decimal isbn13, string title, string contents)
        {
            this.isbn13 = isbn13;
            this.title = title;
            this.contents = contents;
        }

        //Object 클래스의 Equals를 override
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Book book = obj as Book;    //obj 객체를 book으로 형변환
            if (book == null)   //형변환 실패시 as 예약어는 null을 반환해준다.
                return false;
            return this.isbn13 == book.isbn13;  //두 isbn13을 비교
        }
        //Object 클래스의 GetHashCode를 재정의
        public override int GetHashCode()
        {
            return this.isbn13.GetHashCode();
        }
    }
    class ObjectOverride2
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            Book book2 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
            Book book3 = new Book(9788992939409, "파이썬 3.6 프로그래밍", "......");

            Console.WriteLine("book1 == book2 : " + book1.Equals(book2));
            Console.WriteLine("book1 == book3 : " + book1.Equals(book3));
            if(book1.GetHashCode() == book2.GetHashCode())
            {
                Console.WriteLine("book1이랑 book2은 같은 인스턴스입니다.");
            }
            else if(book1.GetHashCode() == book3.GetHashCode())
            {
                Console.WriteLine("book1이랑 book3은 같은 인스턴스입니다.");
            }
            else
            {
                Console.WriteLine("같은 인스턴스는 없습니다.");
            }
        }
    }
}
