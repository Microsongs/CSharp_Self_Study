using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    class Book
    {
        private decimal isbn;
        public Book(decimal isbn)
        {
            this.isbn = isbn;
        }
    }
    class GetHashCode
    {
        static void Main(string[] args)
        {
            //값 형식에 대한 GetHashCode
            short n1 = 256;
            short n2 = 32750;
            short n3 = 256;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(n3.GetHashCode());    //n1와 동일한 HashCode값을 반환

            //참조 형식에 대한 GetHashCode
            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book2.GetHashCode()); //두 객체의 hashcode가 다르다.
            //객체의 hashcode는 임의의 값이다.
        }
    }
}
