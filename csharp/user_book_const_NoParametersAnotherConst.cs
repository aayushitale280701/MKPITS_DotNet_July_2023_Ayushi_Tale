using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userparameterconstroctor
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        //creating a  parameterized constructor with 4 parameters
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("Constructor with  parameters called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("Book id : " + bookid);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Price : " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Title");
            string t1 = Console.ReadLine();
            Console.WriteLine("Enter Author");
            string a1 = Console.ReadLine();
            Console.WriteLine("Enter Price");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Book b2 = new Book(b1, t1, a1, p1); //this will call parameterized constructor
            b2.display();
        }
    }
}
