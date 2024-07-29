using IndexProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndexProgram;

namespace IndexProgram.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestStudentId()
        {
            Student student = new Student("S001", "John", "Doe", "Mathematics", 85.5);
            Assert.AreEqual("S001", student[0]);
        }

        [TestMethod]
        public void TestFirstName()
        {
            Student student = new Student("S001", "John", "Doe", "Mathematics", 85.5);
            Assert.AreEqual("John", student[1]);
        }

        [TestMethod]
        public void TestUpdateLastName()
        {
            Student student = new Student("S001", "John", "Doe", "Mathematics", 85.5);
            student[2] = "Smith";
            Assert.AreEqual("Smith", student[2]);
        }

        [TestMethod]
        public void TestCourse()
        {
            Student student = new Student("S001", "John", "Doe", "Mathematics", 85.5);
            Assert.AreEqual("Mathematics", student[3]);
        }

        [TestMethod]
        public void TestUpdateGrade()
        {
            Student student = new Student("S001", "John", "Doe", "Mathematics", 85.5);
            student[4] = 90.0;
            Assert.AreEqual(90.0, student[4]);
        }
    }
}
