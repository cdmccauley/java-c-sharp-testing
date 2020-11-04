using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumFebDays()
        {
            Assert.AreEqual(28, LeapYear.Program.numFebDays(2007));

            Assert.AreEqual(29, LeapYear.Program.numFebDays(2000));
            Assert.AreEqual(28, LeapYear.Program.numFebDays(2001));
            Assert.AreEqual(29, LeapYear.Program.numFebDays(1904));
            Assert.AreEqual(28, LeapYear.Program.numFebDays(1900));
            Assert.AreEqual(29, LeapYear.Program.numFebDays(2020));
            Assert.AreEqual(28, LeapYear.Program.numFebDays(2015));
            Assert.AreEqual(29, LeapYear.Program.numFebDays(2012));
            Assert.AreEqual(28, LeapYear.Program.numFebDays(1950));
            Assert.AreEqual(29, LeapYear.Program.numFebDays(2004));
            Assert.AreEqual(28, LeapYear.Program.numFebDays(2100));
        }

        [TestMethod]
        public void TestIsLeapYear()
        {
            Assert.IsFalse(LeapYear.Program.isLeapYear(2007));

            Assert.IsTrue(LeapYear.Program.isLeapYear(2000));
            Assert.IsFalse(LeapYear.Program.isLeapYear(2001));
            Assert.IsTrue(LeapYear.Program.isLeapYear(1904));
            Assert.IsFalse(LeapYear.Program.isLeapYear(1900));
            Assert.IsTrue(LeapYear.Program.isLeapYear(2020));
            Assert.IsFalse(LeapYear.Program.isLeapYear(2015));
            Assert.IsTrue(LeapYear.Program.isLeapYear(2012));
            Assert.IsFalse(LeapYear.Program.isLeapYear(1950));
            Assert.IsTrue(LeapYear.Program.isLeapYear(2004));
            Assert.IsFalse(LeapYear.Program.isLeapYear(2100));
        }
    }
}
