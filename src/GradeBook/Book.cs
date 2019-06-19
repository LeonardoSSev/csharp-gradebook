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

        public int AddGrade(double grade)
        {
            if (grade < 0.0 || grade > 10.0) {
                Console.WriteLine("Invalid grade.");
                return 0;
            }

            this.grades.Add(grade);

            return 1;
        }

        public void AddLetterGrade(char gradeLetter)
        {
            switch(gradeLetter)
            {
                case var letter when letter.Equals("A"):
                    this.AddGrade(10.0);
                    break;
                case var letter when letter.Equals("B"):
                    this.AddGrade(9.0);
                    break;
                case var letter when letter.Equals("C"):
                    this.AddGrade(7.0);
                    break;
                case var letter when letter.Equals("D"):
                    this.AddGrade(6.0);
                    break;
                default:
                    this.AddGrade(0.0);
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.High = this.GetHighestGrade();
            statistics.Low = this.GetLowestGrade();
            statistics.Average = this.GetAverage();
            statistics.DefineAverageLetter();

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

