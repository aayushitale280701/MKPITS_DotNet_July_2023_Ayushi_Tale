using System;
namespace findavreage
{

    class student
    {
        string name;
        int rollno;
        int[] marks;

        public void getdata(string name, int rollno, int[] marks)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks = marks;

        }
        public void displaydata()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Roll no:" + rollno);
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                total = total + marks[i];
            }
               float  avg = total/3.0f;
            Console.WriteLine(" Avrage of student: " + avg);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
           
            student s1 = new student();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter roll no");
            int rn = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[3];
            Console.WriteLine("Enter 3 subject marks");

            for (int i = 0; i < 3; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            s1.getdata(name, rn, marks);
            s1.displaydata();

            Console.ReadKey();
        }
    }
}
