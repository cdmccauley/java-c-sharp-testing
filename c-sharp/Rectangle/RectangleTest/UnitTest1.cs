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
            Assert.AreEqual(40, new Box(12, 8).getPerimeter());
        }

        [TestMethod]
        public void TestArea()
        {
            Assert.AreEqual(96, new Box(12, 8).getArea());
            Assert.AreEqual(96, new Box(12, 8).getArea());
        }

        [TestMethod]
        public void TestVolume()
        {
            Assert.AreEqual(960, new Box(12, 8, 10).getVolume());
            Assert.AreEqual(960, new Box(12, 8, 10).getVolume());
        }
    }
}
