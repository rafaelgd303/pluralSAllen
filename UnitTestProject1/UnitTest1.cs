using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace UnitTestProject1
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

            Assert.AreEqual("New name aaa", book2.Name);

        }

        private void GiveName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "New name aaa";
        }
    }
}
