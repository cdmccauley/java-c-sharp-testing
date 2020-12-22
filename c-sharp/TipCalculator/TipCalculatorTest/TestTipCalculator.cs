using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipCalculatorTest
{
    [TestClass]
    public class TestTipCalculator
    {
        [DataRow(30.0, 15.0, 4.50)]
        [DataRow(30.0, 18.0, 5.40)] 
        [DataRow(30.0, 20.0, 6.00)] 
        [DataRow(30.0, 22.0, 6.60)] 
        [DataRow(30.0, 25.0, 7.50)]

        [DataTestMethod]
        public void TestCalcTip(double cost, double rate, double expected)
        {
            Assert.AreEqual(TipCalculator.Program.calcTip(cost, rate), expected, 0.000);
        }

        [DataRow(30.0, 4.50, 34.50)]
        [DataRow(30.0, 5.40, 35.40)]
        [DataRow(30.0, 6.00, 36.00)]
        [DataRow(30.0, 6.60, 36.60)]
        [DataRow(30.0, 7.50, 37.50)]

        [DataTestMethod]
        public void TestCalcTotal(double cost, double rate, double expected)
        {
            Assert.AreEqual(TipCalculator.Program.calcTotal(cost, rate), expected, 0.000);
        }
    }
}
