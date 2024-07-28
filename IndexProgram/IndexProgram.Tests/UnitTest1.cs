using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndexProject;
using System;
using System.IO;
using IndexProgram;

namespace IndexProject.Tests
{
    [TestClass]
    public class IndexTests
    {
        [TestMethod]
        public void TestIndexSetAndGet()
        {
            var index = new Index(5);
            index[0] = 10;
            Assert.AreEqual(10, index[0]);
        }

        [TestMethod]
        public void TestIndexOutOfRange()
        {
            var index = new Index(5);
            Assert.ThrowsException<IndexOutOfRangeException>(() => index[5] = 10);
        }

        [TestMethod]
        public void TestDisplay()
        {
            var index = new Index(3);
            index[0] = 1;
            index[1] = 2;
            index[2] = 3;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                index.Display();
                var result = sw.ToString().Trim();
                Assert.AreEqual("1\r\n2\r\n3", result);
            }
        }

        [TestMethod]
        public void TestInitialValues()
        {
            var index = new Index(4);
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(0, index[i], $"Initial value at index {i} should be 0.");
            }
        }

        [TestMethod]
        public void TestUpdateValues()
        {
            var index = new Index(3);
            index[0] = 5;
            index[1] = 10;
            index[2] = 15;

            Assert.AreEqual(5, index[0]);
            Assert.AreEqual(10, index[1]);
            Assert.AreEqual(15, index[2]);
        }
    }
}
