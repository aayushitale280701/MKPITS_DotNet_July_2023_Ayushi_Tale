using System;
namespace classStd
{
    class Student
    {
        int student_rollno;
        string student_name;
        string student_course;
        int student_fee;

        public void getdata()
        {
            student_rollno = 11;
            student_name = "Ayushi";
            student_course = "DotNet";
            student_fee = 20000;

        }
        //method overloaded
        public void getdata(int  student_rollno)
        {
            this.student_name = student_name;
        }
        public void getdata(int student_rollno, string student_name)
        {
            this.student_name = student_name;
            this.student_rollno= student_rollno;
        }
        
        public void getdata(int student_rollno, string student_name, string  student_course)
        {
            this.student_rollno = student_rollno;
            this.student_name = student_name;
            this.student_course = student_course;
        }
        public void getdata(int student_rollno, string student_name, string student_course, int student_fee)
        {
            this.student_rollno=student_rollno;
            this.student_name = student_name;
            this.student_course=student_course;
            this.student_fee=student_fee;
        }
        public void display()
        {
            Console.WriteLine("Student RollNo= " + student_rollno);
            Console.WriteLine("Student Name= " + student_name);
            Console.WriteLine("Student Course= " + student_course);
            Console.WriteLine("Student Fee= " + student_fee);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.getdata();
            std.display();
            Console.WriteLine("Student Details\n");
            Student std1=new Student();
            std1.getdata(22,"Om");
            std1.display();
            Console.WriteLine("Student1 Details\n");
            Student std2 =new Student();
            std2.getdata(22,"Om", "DotNet");
            std2.display();
            Console.WriteLine("Student2 Details\n");
            Student std3=new Student();
            std3.getdata(22, "Om", "DotNet", 50000);
            std3.display();
            Console.ReadKey();
        }
    }
}