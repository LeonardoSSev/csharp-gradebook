using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.Name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.High = this.GetHighestGrade();
            statistics.Low = this.GetLowestGrade();
            statistics.Average = this.GetAverage();

            return statistics;
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

