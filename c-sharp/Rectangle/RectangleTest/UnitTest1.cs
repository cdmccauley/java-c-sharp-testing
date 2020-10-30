using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimeter()
        {
            Assert.AreEqual(40, new Box(12, 8).getPerimeter());
            Assert.AreEqual(30, new Box(5, 10).getPerimeter());
            Assert.AreEqual(44, new Box(12, 10).getPerimeter());
            Assert.AreEqual(60, new Box(10, 20).getPerimeter());

        }

        [TestMethod]
        public void TestArea()
        {
            Assert.AreEqual(96, new Box(12, 8).getArea());
            Assert.AreEqual(50, new Box(5, 10).getArea());
            Assert.AreEqual(120, new Box(12, 10).getArea());
            Assert.AreEqual(200, new Box(10, 20).getArea());
        }

        [TestMethod]
        public void TestVolume()
        {
            Assert.AreEqual(960, new Box(12, 8, 10).getVolume());
            Assert.AreEqual(750, new Box(5, 10, 15).getVolume());
            Assert.AreEqual(1080, new Box(12, 10, 9).getVolume());
            Assert.AreEqual(6000, new Box(10, 20, 30).getVolume());
        }
    }
}
