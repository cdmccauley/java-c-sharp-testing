using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumFebDays()
        {
            // not able to run?
            Assert.Equals(0, LeapYear.Program.numFebDays());
        }

        [TestMethod]
        public void TestIsLeapYear()
        {
            // not able to run?
            Assert.IsTrue(LeapYear.Program.isLeapYear());
        }
    }
}
