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

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

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
            b.getdata();
            b.display();
            Console.WriteLine("-----------------Book1 Details ----------");
            Book b1 = new Book();
            b1.getdata(111, "csharp");
            b1.display();

            Console.WriteLine("-----------------Book2 Details ----------");
            Book b2 = new Book();
            b2.getdata(111, "csharp", "manish");
            b2.display();

            Console.WriteLine("-----------------Book3 Details ----------");

            Book b3 = new Book();
            b3.getdata(111, "csharp", "arti", 444);
            b3.display();

            Console.WriteLine("-----------------Book4 Details ----------");

            Console.ReadLine();

        }
    }
}
