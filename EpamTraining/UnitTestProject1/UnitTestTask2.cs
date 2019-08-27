using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary.CLasses;
using Task2;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTask2
    {
        [TestMethod]
        public void TestTask2_1()
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(square.Draw(), square.GetType().Name);
            Assert.AreEqual(rectangle.Draw(), rectangle.GetType().Name);
        }

        [TestMethod]
        public void TestTask2_2()
        {
            Square2 square = new Square2(3, 4);
            Rectangle2 rectangle = new Rectangle2(5, 7);
            Assert.AreEqual(square.Draw(), square.GetType().Name);
            Assert.AreEqual(rectangle.Draw(), rectangle.GetType().Name);
        }

        [TestMethod]
        public void TestTask2_3()
        {
            Figure3 figure = new Figure3(4, 6);
            Square3 square = new Square3(3, 4);
            Rectangle3 rectangle = new Rectangle3(5, 7);
            Assert.AreEqual(figure.Draw(), figure.GetType().Name);
            Assert.AreEqual(square.Draw(), square.GetType().Name);
            Assert.AreEqual(rectangle.Draw(), rectangle.GetType().Name);
        }

        [TestMethod]
        public void TestTask2_4()
        {
            Figure4 figure = new Figure4(4, 6);
            Square4 square = new Square4(3, 4);
            Rectangle4 rectangle = new Rectangle4(5, 7);
            Assert.AreEqual(figure.Draw(), figure.GetType().Name);
            Assert.AreEqual(square.Draw(), square.GetType().Name);
            Assert.AreEqual(rectangle.Draw(), rectangle.GetType().Name);
        }
    }
}
