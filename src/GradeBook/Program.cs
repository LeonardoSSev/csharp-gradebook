using Gradebook;

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

            book.ShowStatistics();
        }
    }
}
