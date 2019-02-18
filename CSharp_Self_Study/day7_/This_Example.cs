using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day7_
{
    class Book
    {
        decimal isbn;
        public Book(decimal isbn)
        {
            this.isbn = isbn;   //this를 생략하면 메서드의 매개변수인 isbn 변수가 사용된다.
        }
        public void Print()
        {
            Console.WriteLine(isbn);
        }
    }
    class This_Example
    {
        static void Main(string[] args)
        {
            Book book = new Book(123123123);
            book.Print();
        }
    }
}
