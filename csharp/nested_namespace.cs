using System;
using First;
using F.Second;
namespace First
{
    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Namespace Hello ");
        }
    }
}
namespace F.Second
{
    public class Hii
    {
        public void SayHey()
        {
            Console.WriteLine("Namespace Hii");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hello h1 = new Hello();
        Hii h2 = new Hii();
        h1.SayHello();
        h2.SayHey();
        Console.ReadKey();
    }
}