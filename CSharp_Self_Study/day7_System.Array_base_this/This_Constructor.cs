using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    class Book
    {
        private string title;
        private decimal isbn;
        private string author;
        public Book(string title, decimal isbn, string author)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
        }

        //this 예약어로 생성자 재호출
        public Book(string title, decimal isbn) : this(title, isbn, string.Empty)
        {

        }
        public Book(string title) : this(title, 0, string.Empty)
        {

        }
        public Book() : this(string.Empty,0,string.Empty)
        {

        }
    }

    class This_Constructor
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("안녕");
            Book book3 = new Book("하세요", 20);
            Book book4 = new Book("감사합니다", 20, "tomato");
        }
    }
}
