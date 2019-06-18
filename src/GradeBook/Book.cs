using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public double GetHighestGrade()
        {
            var highestGrade = double.MinValue;

            foreach (double grade in this.grades) 
            {
                highestGrade = Math.Max(grade, highestGrade);
            }

            return highestGrade;
        }

        public double GetLowestGrade()
        {
            var lowestGrade = double.MaxValue;

            foreach (double grade in this.grades) 
            {
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            return lowestGrade;
        }
    }
}

