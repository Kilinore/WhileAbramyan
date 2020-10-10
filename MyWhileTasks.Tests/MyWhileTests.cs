using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyWhileTasks.Tests
{
    [TestClass]
    public class MyWhileTests
    {
        [TestMethod]
        public void While1_12and5_2expected()
        {
            // arrange
            int x = 12;
            int y = 5;
            int expected = 2;

            // act
            MyWhileTasks t = new MyWhileTasks();
            int actual = t.While1(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void While21_2221_TRUEexpected()
        {
            // arrange
            int x = 2221;
            string expected = "TRUE";

            // act
            MyWhileTasks t = new MyWhileTasks();
            string actual = t.While21(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
