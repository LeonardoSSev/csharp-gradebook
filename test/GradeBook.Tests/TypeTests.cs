using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            var name = "Leonardo";
            var uppercaseName = this.GetUppercase(name);

            Assert.Equal("Leonardo", name);
            Assert.Equal("LEONARDO", uppercaseName);
        }

        private string GetUppercase(string word)
        {
            return word.ToUpper();
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var intValue = GetInt();
            SetInt(ref intValue);

            Assert.Equal(42, intValue);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int intValue)
        {
            intValue = 42;
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            var book1 = this.GetBook("Book 1");
            this.GetBookSetName(out book1, "New Name");
        
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = this.GetBook("Book 1");
            this.GetBookSetName(book1, "New Name");
        
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = this.GetBook("Book 1");
            this.SetName(book1, "New Name");
        
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = this.GetBook("Book 1");
            var book2 = this.GetBook("Book 2");
        
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = this.GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
