using System;
using System.Threading.Channels;

namespace First
{
    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("First namespace hello");
        }
    }
}
namespace Second
{
    public class Hii
    {
        public void hii()
        {
            Console.WriteLine("Second namespace hello");
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        First.Hello h1 = new First.Hello();
        Second.Hii h2 = new Second.Hii();
        h1.SayHello();
        h2.hii();
        Console.ReadLine();
    }
}