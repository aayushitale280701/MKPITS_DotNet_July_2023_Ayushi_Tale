using System;
namespace acceptfromuserchar
{
    class program
    {
        enum grade
        {
            A=90, B=80, C=46
        }
        static void Main(string[] args) 
        {
            grade gr;
            gr = grade.A;
            Console.WriteLine("grade ="+gr);
            Console.WriteLine("grade value =" + Convert.ToInt32(gr));

        }
    }
}
