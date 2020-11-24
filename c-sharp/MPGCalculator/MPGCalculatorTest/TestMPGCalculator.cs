using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MPGCalculatorTest
{
    [TestClass]
    public class TestMPGCalculator
    {
        [TestMethod]
        public void TestMPGInstance()
        {
            MPG instance = new MPG(300, 10);

        }
    }
}
