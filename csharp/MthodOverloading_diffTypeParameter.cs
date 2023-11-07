using System;
namespace typeofdiffpara
{
    class Calculate
    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition of 2 int is : "+res);
        }
        public void addition (float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition of 2 float is : " + res);
        }
        class program
        {
            public static void Main(string[] args)
            {
                Calculate c = new Calculate();
                c.addition(1, 2);
                Console.WriteLine("--------Now calling adding float is------- ");
                c.addition(2.2f,3.2f);
                Console.ReadKey();
            }
        }
    }
}