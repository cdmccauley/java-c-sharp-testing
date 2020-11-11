using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFToC()
        {
            Assert.AreEqual(0.0, TemperatureConverter.Program.FToC(0.0));
        }

        [TestMethod]
        public void TestCToF()
        {
            Assert.AreEqual(0.0, TemperatureConverter.Program.CToF(0.0));
        }
    }
}
