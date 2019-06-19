using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Leonardo's Book");

            book.AddGrade(10.0);
            book.AddGrade(9.5);
            book.AddGrade(10.0);
            book.AddGrade(6.9);
            book.AddLetterGrade('C');
            book.AddLetterGrade('D');

            var statistics = book.GetStatistics();

            Console.WriteLine($"The highest grade is {statistics.High:N1}.");
            Console.WriteLine($"The lowest grade is {statistics.Low:N1}.");
            Console.WriteLine($"The average grade is {statistics.Average:N1}.");
        }
    }
}
