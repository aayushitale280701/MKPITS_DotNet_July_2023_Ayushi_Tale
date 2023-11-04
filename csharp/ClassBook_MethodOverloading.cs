using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            b1.getdata(111, "Csharp", "Martin", 2000);
            b1.display();

            Console.WriteLine("-----------------Book1 Details ----------");
            Console.WriteLine("Enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter title");
            String title = Console.ReadLine();
            Console.WriteLine("Enter author");
            String author = Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------Book2 Details ----------");
            Book b2 = new Book();
            b2.getdata(id, title, author, price);
            b2.display();


            Console.ReadLine();

        }
    }
}
