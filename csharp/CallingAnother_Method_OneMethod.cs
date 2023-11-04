using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{

    class Book
    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            price = 200;

        }
        //method overloaded 
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "HTML");

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "Ayushi");

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 234);

        }
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id = " + bookid);
            Console.WriteLine("Book Title = " + title);
            Console.WriteLine("Book Author= " + author);
            Console.WriteLine("Price = " + price);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(899);
            b.display();
            Console.WriteLine("-----------------Book1 Details ----------");
            Console.ReadLine();

        }
    }
}
