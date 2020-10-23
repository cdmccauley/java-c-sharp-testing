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
        }
    }
}
