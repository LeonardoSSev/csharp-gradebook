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
    }
}
