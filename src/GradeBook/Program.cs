using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = Program.CreateBook();

            Program.AddGradeIntoBook(book);

            Program.ShowStatistics(book);
        }

        static Book CreateBook()
        {
            Console.WriteLine("Input he name of the book: ");
            var name = Console.ReadLine();
            
            var book = new Book(name);

            return book;
        }

        static void AddGradeIntoBook(Book book)
        {
            
            int count = 0;
            do {
                Console.WriteLine($"Input the grade number {count+1}:");
                var grade = double.Parse(Console.ReadLine());

                var result = Program.InputGrade(book, grade);

                count++;
            } while (count < 4);
        }

        static int InputGrade(Book book, double grade)
        {
            var result = book.AddGrade(grade);

            return result;
        }

        static void ShowStatistics(Book book)
        {
            var statistics = book.GetStatistics();

            Console.WriteLine($"The highest grade is {statistics.High:N1}.");
            Console.WriteLine($"The lowest grade is {statistics.Low:N1}.");
            Console.WriteLine($"The average grade is {statistics.Average:N1}.");
            Console.WriteLine($"The letter is {statistics.Letter}.");
        }
    }
    
}
