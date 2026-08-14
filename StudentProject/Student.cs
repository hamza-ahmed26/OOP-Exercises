using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public List<double> Grades { get; private set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
            Grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            double sum = 0;
            foreach (double grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Count;
        }
    }
}

