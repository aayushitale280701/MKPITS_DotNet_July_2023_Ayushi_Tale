using System;
namespace rectangle_findarea
{
   
        class rectangle
        {
            int width;
            int height;          
            float area;
            public void getdata( int width, int height)
            {
                
                this.width = width;
                this.height = height;
                area = width * height;

            }
            public void displaydata()
            {
                Console.WriteLine("Area of Rectangle : " +area);
            }
        }
    class program
    { 
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.getdata(5,10);
            r.displaydata();
            Console.ReadKey();
        }
    }
}