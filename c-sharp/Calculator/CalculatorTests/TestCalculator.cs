using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(-0.0, testInstance.Subtraction(0.0, 0.0));
            Assert.AreEqual(5.0, testInstance.Subtraction(10.0, 5.0));
            Assert.AreEqual(7.0, testInstance.Subtraction(12.0, 5.0));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(0.0, testInstance.Multiplication(0.0, 0.0));
            Assert.AreEqual(100.0, testInstance.Multiplication(10.0, 10.0));
            Assert.AreEqual(60.0, testInstance.Multiplication(12.0, 5.0));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(double.NaN, testInstance.Division(0.0, 0.0));
            Assert.AreEqual(0.0, testInstance.Division(0.0, 80.0));
            Assert.AreEqual(2.4, testInstance.Division(12.0, 5.0));
        }
    }
}
