using System;
using System.Collections.Generic;


namespace StudentsCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack:\n");

            Stack<Student> students = new Stack<Student>();

            students.Push(new Student() { Name = "Vitja Popov" });
            students.Peek().DoHomework();
            students.Push(new Student() { Name = "Boris Burda" });
            students.Peek().DoHomework();
            students.Push(new Student() { Name = "Tolja Hitrik" });
            students.Peek().DoHomework();

            while (students.Count > 0)
            {
                students.Pop().GetCoffee();
            }

            
            Console.WriteLine("\nQueue:\n");

            Queue<Student> studentsQueue = new Queue<Student>();

            Student student;

            studentsQueue.Enqueue(student = new Student () { Name = "Vitja Popov" });
            student.DoHomework();
            studentsQueue.Enqueue(student = new Student() { Name = "Boris Burda" });
            student.DoHomework();
            studentsQueue.Enqueue(student = new Student() { Name = "Tolja Hitrik" });
            student.DoHomework();

            while (studentsQueue.Count > 0)
            {
                studentsQueue.Dequeue().GetCoffee();
            }

            Console.ReadLine();

        }

    }
}
