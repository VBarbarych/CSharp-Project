using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary.CLasses;
using Task1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTask1
    {
        [TestMethod]
        public void TestTask1_1()
        {
            Point x = new Point(1, 3);
            Point y = new Point(5, 1);
            Task1_1 rectangle = new Task1_1(x, y);
            Assert.AreEqual(rectangle.Square(), 8);
            Assert.AreEqual(rectangle.Perimeter(), 12);
        }

        [TestMethod]
        public void TestTask1_2()
        {
            Point x = new Point(1, 3);
            Point y = new Point(5, 1);
            Task1_2 rectangle = new Task1_2(x, y);
            Assert.AreEqual(rectangle.Square, 8);
            Assert.AreEqual(rectangle.Perimeter, 12);
        }

        [TestMethod]
        public void TestTask1_3()
        {
            var radius = 3;
            Task1_3 circle = new Task1_3(radius);
            Assert.AreEqual(circle.Perimeter(radius), 18.849, 0.01);
            Assert.AreEqual(circle.Square(radius), 28.274, 0.01);
        }

        [TestMethod]
        public void TestTask1_5()
        {
            Task1_5 c1 = new Task1_5();
            Task1_5 c2 = new Task1_5();
            c1.Real = 1;
            c1.Imaginary = 7;
            c2.Real = 2;
            c2.Imaginary = 5;
            Assert.AreEqual((c1 * c2).Real, -33);
            Assert.AreEqual((c1 * c2).Imaginary, 19);
            Assert.AreEqual((c1 / c2).Real, 1.275, 0.001);
            Assert.AreEqual((c1 / c2).Imaginary, 0.310, 0.001);
        }
    }
}
