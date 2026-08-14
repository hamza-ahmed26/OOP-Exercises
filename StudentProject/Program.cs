using System;
using System.Collections.Generic;

namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student("Ahmed Ali", 101);
            student1.AddGrade(85);
            student1.AddGrade(90);
            student1.AddGrade(78);
            students.Add(student1);

            Student student2 = new Student("hala Mohamed", 102);
            student2.AddGrade(95);
            student2.AddGrade(88);
            students.Add(student2);

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name} (ID: {student.Id})");
                Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
                Console.WriteLine();
            }
        }
    }
}