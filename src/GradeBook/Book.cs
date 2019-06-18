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

        public void ShowStatistics()
        {
            var highestGrade = this.GetHighestGrade();
            var lowestGrade = this.GetLowestGrade();
            var average = this.GetAverage();

            Console.WriteLine($"The highest grade is {highestGrade}.");
            Console.WriteLine($"The lowest grade is {lowestGrade}.");
            Console.WriteLine($"The average grade is {average}.");
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

        public double GetAverage()
        {
            double total = 0.0;

            foreach (double grade in this.grades) {
                total += grade;
            }

            var average = total / this.grades.Count;

            return average;
        }
    }
}

