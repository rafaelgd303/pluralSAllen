using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveName(book2);
            Assert.AreEqual("A new book name", book1.Name);

        }
        private void GiveName(GradeBook book)
        {
            book.Name = "A new book name";
        }
    }
}
