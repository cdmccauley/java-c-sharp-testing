using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckDigitsTest
{
    [TestClass]
    public class TestCheckDigitsMethods
    {

        private CheckDigits.CheckDigitsMethods methods;

        public TestCheckDigitsMethods()
        {
            methods = new CheckDigits.CheckDigitsMethods();
        }

        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0 }, 3.0)]
        [DataRow(new double[] { 12.3, -51.7, 89.4, 27.0 }, 77.0)]
        public void TestGetTotal(double[] testNumbers, double expected)
        {
            Assert.AreEqual(expected, methods.getTotal(new List<double>(testNumbers)), 0.0);
        }

        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0 }, 1.5)]
        [DataRow(new double[] { 12.3, -51.7, 89.4, 27.0 }, 19.25)]
        public void TestGetAverage(double[] testNumbers, double expected)
        {
            Assert.AreEqual(expected, methods.getAverage(new List<double>(testNumbers)), 0.0);
        }

        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0 }, 2.0)]
        [DataRow(new double[] { 12.3, -51.7, 89.4, 27.0 }, 89.4)]
        public void TestGetLargest(double[] testNumbers, double expected)
        {
            Assert.AreEqual(expected, methods.getLargest(new List<double>(testNumbers)), 0.0);
        }

        [DataTestMethod]
        [DataRow(new double[] { 1.0, 2.0 }, 1.0)]
        [DataRow(new double[] { 12.3, -51.7, 89.4, 27.0 }, -51.7)]
        public void TestGetSmallest(double[] testNumbers, double expected)
        {
            Assert.AreEqual(expected, methods.getSmallest(new List<double>(testNumbers)), 0.0);
        }
    }
}
