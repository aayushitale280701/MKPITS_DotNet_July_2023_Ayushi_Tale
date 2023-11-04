using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingdiff
{
    class Book
    {
        int bookid;
        string title;

        //creating a overlaoded method with 4 parameters
        public void getdata(int bookid, string title)
        {
            Console.WriteLine("Method  with  integer first called");
            this.bookid = bookid;
            this.title = title;


        }
        public void getdata(string title, int bookid)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void display()
        {
            Console.WriteLine("Book id : " + bookid);
            Console.WriteLine("Title : " + title);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter title");
            string t1 = Console.ReadLine();
            ;

            Book b2 = new Book();
            b2.getdata(b1, t1); //this will call method with parameters
            b2.display();
            Console.WriteLine("Passing string first then integer");
            b2.getdata(t1, b1);
            b2.display();



        }
    }
}
