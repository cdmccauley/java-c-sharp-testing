using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFToC()
        {
            Assert.AreEqual(0.0, TemperatureConverter.Program.FToC(32.0), 0.00);
            Assert.AreEqual(100.0, TemperatureConverter.Program.FToC(212.0), 0.00);
            Assert.AreEqual(37.0, TemperatureConverter.Program.FToC(98.6), 0.00);
        }

        [TestMethod]
        public void TestCToF()
        {
            Assert.AreEqual(32.0, TemperatureConverter.Program.CToF(0.0), 0.00);
            Assert.AreEqual(212.0, TemperatureConverter.Program.CToF(100.0), 0.00);
            Assert.AreEqual(98.6, TemperatureConverter.Program.CToF(37.0), 0.00);
        }
    }
}
