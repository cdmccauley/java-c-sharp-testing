using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class TestCalculator
    {
        Operations testInstance;

        public TestCalculator()
        {
            testInstance = new Operations();
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(0.0, testInstance.Addition(0.0, 0.0));
            Assert.AreEqual(15.0, testInstance.Addition(10.0, 5.0));
            Assert.AreEqual(17.0, testInstance.Addition(12.0, 5.0));
        }

        [DataRow(0.0, 0.0, 0.0)]
        [DataRow(15.0, 10.0, 5.0)]
        [DataRow(17.0, 12.0, 5.0)]
        [DataTestMethod]
        public void TestDoubleAddition(double expected, double left, double right)
        {
            Assert.AreEqual(expected, testInstance.Addition(left, right));
        }

        [DataRow(0, 0, 0)]
        [DataRow(15, 10, 5)]
        [DataRow(17, 12, 5)]
        [DataTestMethod]
        public void TestIntegerAddition(int expected, int left, int right)
        {
            Assert.AreEqual(expected, testInstance.Addition(left, right));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(-0.0, testInstance.Subtraction(0.0, 0.0));
            Assert.AreEqual(5.0, testInstance.Subtraction(10.0, 5.0));
            Assert.AreEqual(7.0, testInstance.Subtraction(12.0, 5.0));
        }

        [DataRow(-0.0, 0.0, 0.0)]
        [DataRow(5.0, 10.0, 5.0)]
        [DataRow(7.0, 12.0, 5.0)]
        [DataTestMethod]
        public void TestDoubleSubtraction(double expected, double left, double right)
        {
            Assert.AreEqual(expected, testInstance.Subtraction(left, right));
        }

        [DataRow(-0, 0, 0)]
        [DataRow(5, 10, 5)]
        [DataRow(7, 12, 5)]
        [DataTestMethod]
        public void TestIntegerSubtraction(int expected, int left, int right)
        {
            Assert.AreEqual(expected, testInstance.Subtraction(left, right));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(0.0, testInstance.Multiplication(0.0, 0.0));
            Assert.AreEqual(100.0, testInstance.Multiplication(10.0, 10.0));
            Assert.AreEqual(60.0, testInstance.Multiplication(12.0, 5.0));
        }

        [DataRow(0.0, 0.0, 0.0)]
        [DataRow(100.0, 10.0, 10.0)]
        [DataRow(60.0, 12.0, 5.0)]
        [DataTestMethod]
        public void TestDoubleMultiplication(double expected, double left, double right)
        {
            Assert.AreEqual(expected, testInstance.Multiplication(left, right));
        }

        [DataRow(0, 0, 0)]
        [DataRow(100, 10, 10)]
        [DataRow(60, 12, 5)]
        [DataTestMethod]
        public void TestIntegerMultiplication(int expected, int left, int right)
        {
            Assert.AreEqual(expected, testInstance.Multiplication(left, right));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(double.NaN, testInstance.Division(0.0, 0.0));
            Assert.AreEqual(0.0, testInstance.Division(0.0, 80.0));
            Assert.AreEqual(2.4, testInstance.Division(12.0, 5.0));
        }

        [DataRow(double.NaN, 0.0, 0.0)]
        [DataRow(0.0, 0.0, 80.0)]
        [DataRow(2.4, 12.0, 5.0)]
        [DataTestMethod]
        public void TestDoubleDivision(double expected, double left, double right)
        {
            Assert.AreEqual(expected, testInstance.Division(left, right));
        }

        [DataRow(0, 0, 80)]
        [DataRow(2, 12, 5)]
        [DataTestMethod]
        public void TestIntegerDivision(int expected, int left, int right)
        {
            Assert.AreEqual(expected, testInstance.Division(left, right));
        }

        [DataRow(0, 0, 0)]
        [DataTestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestIntegerDivisionException(int expected, int left, int right)
        {
            testInstance.Division(left, right);
        }
    }
}
