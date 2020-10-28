using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimeter()
        {
            // declarations
            Box testBox = new Box(12, 8);
            double expected = 40;
            double actual;

            // call method
            actual = testBox.getPerimeter();

            // test variables
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(40, new Box(12, 8).getPerimeter());
        }

        [TestMethod]
        public void TestArea()
        {
            // declarations
            Box testBox = new Box(12, 8);
            double expected = 96;
            double actual;

            // call method
            actual = testBox.getArea();

            // test variables
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(96, new Box(12, 8).getArea());
        }

        [TestMethod]
        public void TestVolume()
        {
            // declarations
            Box testBox = new Box(12, 8, 10);
            double expected = 960;
            double actual;

            // call method
            actual = testBox.getVolume();

            // test variables
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(960, new Box(12, 8, 10).getVolume());
        }
    }
}
