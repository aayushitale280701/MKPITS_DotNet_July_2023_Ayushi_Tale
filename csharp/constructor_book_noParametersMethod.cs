using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{

    class Book
    {
        int bookid;
        String title, author;
        int price;
        //creating a constructor with no parameters
        public Book()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();//this will call constructor automatically
            b.display();
            Console.ReadLine();
        }
    }
}
