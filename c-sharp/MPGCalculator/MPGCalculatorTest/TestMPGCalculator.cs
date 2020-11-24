using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MPGCalculatorTest
{
    [TestClass]
    public class TestMPGCalculator
    {
        [TestMethod]
        public void TestMPGInstance()
        {
            // arrange
            MPG instance = new MPG(300, 10);

            // act and assert
            Assert.AreEqual(300, instance.Miles, .00);
            Assert.AreEqual(10, instance.Gallons, .00);
            Assert.AreEqual(30, instance.Mpg, .00);
            Assert.AreEqual(300, MPG.TotalMiles, .00);
            Assert.AreEqual(10, MPG.TotalGallons, .00);
            Assert.AreEqual(30, MPG.TotalMPG, .00);
            Assert.AreEqual(1, MPG.NumTrips);
        }
    }
}
