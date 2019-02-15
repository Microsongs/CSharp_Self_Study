using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Self_Study.day6_Object_Type
{
    class Book
    {
        private decimal _isbn;

        public Book(decimal isbn)
        {
            _isbn = isbn;
        }
    }
    class Equals
    {
        static void Main(string[] args)
        {
            // 값 형식의 Equals 비교
            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));

            // 참조 형식의 Equals 비교
            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);
            Console.WriteLine(book1.Equals(book2));

            //string 형식의 Equals 비교
            string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
            string txt2 = new string(new char[] { 't', 'e', 'x', 't' });
            Console.WriteLine(txt1.Equals(txt2));
        }
    }
}
