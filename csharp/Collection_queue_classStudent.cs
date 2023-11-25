using System;
using System.Collections;
namespace collectionQueue
{
    class Student
    {
        public int rno;
        public string name;
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
        class program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student(1, "Ayushi");
                Student s2 = new Student(2, "Om");
                Student s3 = new Student(3, "Ritu");
                Queue s = new Queue();
                s.Enqueue(s1);
                s.Enqueue(s2);
                s.Enqueue(s3);
                foreach(Student val in  s)
                {
                    Console.WriteLine("Roll No: "+val.rno);
                    Console.WriteLine("Name: "+val.name+"\n");
                }
                Student r = (Student)s.Dequeue();
                Console.WriteLine("Item Deque: "+r.rno+" : "+r.name);
                Console.WriteLine("After Deque: ");
                foreach(Student val in s)
                {
                    Console.WriteLine("Name: " + val.name);
                }
                Console.ReadKey();
            }
        }
    }
}