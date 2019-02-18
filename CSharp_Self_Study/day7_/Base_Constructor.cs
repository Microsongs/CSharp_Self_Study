using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    class Book
    {
        decimal isbn13;
        public Book(decimal isbn13)
        {
            this.isbn13 = isbn13;
        }
    }

    class Ebook : Book
    {
        /*
        public Ebook()  //자식 클래스를 생성 -> 부모 클래스의 생성자도 함꼐 호출하는 것
        {

        }
        */
        public Ebook() : base(0)    //매개변수0 초기화
        {

        }
        public Ebook(decimal isbn) : base(isbn) //값을 받아 그것을 부모 클래스의 생성자로 넘겨 초기화
        {

        }
    }

    class Base_Constructor
    {
        static void Main(string[] args)
        {

        }
    }
}
