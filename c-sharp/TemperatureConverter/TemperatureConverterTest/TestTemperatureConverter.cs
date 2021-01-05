using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverterTest
{
    [TestClass]
    public class TestTemperatureConverter
    {
        public const double DELTA = 0.00;

        [DataTestMethod]
        [DataRow(0.0, 32.0, DELTA)]
        [DataRow(100.0, 212.0, DELTA)]
        [DataRow(37.0, 98.6, DELTA)]
        public void TestFToC(double expected, double initial, double d)
        {
            Assert.AreEqual(expected, TemperatureConverter.Program.FToC(initial), d);
        }

        [DataTestMethod]
        [DataRow(32.0, 0.0, DELTA)]
        [DataRow(212.0, 100.0, DELTA)]
        [DataRow(98.6, 37.0, DELTA)]
        public void TestCToF(double expected, double initial, double d)
        {
            Assert.AreEqual(expected, TemperatureConverter.Program.CToF(initial), d);
        }

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
