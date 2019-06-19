using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStatistics()
        {
            var book = new Book("");
            book.AddGrade(10.0);
            book.AddGrade(5.0);
            book.AddGrade(7.5);

            var statistics = book.GetStatistics();

            Assert.Equal(10.0, statistics.High);
            Assert.Equal(5.0, statistics.Low);
            Assert.Equal(7.5, statistics.Average);
        }

        [Fact]
        public void BookOnlyAcceptValidGrades()
        {
            var book = new Book("");

            var validGrade = book.AddGrade(10.0);
            var invalidGrade = book.AddGrade(10.1);

            Assert.Equal(1, validGrade);
            Assert.Equal(0, invalidGrade);
        }

        [Fact]
        public void BookGetHigherGrade()
        {
            var book = new Book("");

            book.AddGrade(10.0);
            book.AddGrade(5.0);

            Assert.Equal(10.0, book.GetHighestGrade());
        }
        
        [Fact]
        public void BookGetLowerGrade()
        {
            var book = new Book("");

            book.AddGrade(10.0);
            book.AddGrade(5.0);

            Assert.Equal(5.0, book.GetLowestGrade());
        }
        
        [Fact]
        public void BookGetAverageGrade()
        {
            var book = new Book("");

            book.AddGrade(10.0);
            book.AddGrade(5.0);

            Assert.Equal(7.5, book.GetAverage());
        }
    }
}
