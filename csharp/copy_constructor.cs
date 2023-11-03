using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class book
    {
        int bookid;
        string title;
        //creating constructor
        public book()
        {
            bookid = 123;
            title = "vb.net";
        }
        //creating a copy constructor
        public book(book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
        }
        //method to display the data
        public void display()
        {
            Console.WriteLine("Book id " + bookid);
            Console.WriteLine("Book title " + title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book book2 = new book(book1);
            Console.WriteLine("Book1 details are :");
            book1.display();
            Console.WriteLine("Book2 details are :");
            book2.display();
            Console.ReadKey();
        }
    }
}
