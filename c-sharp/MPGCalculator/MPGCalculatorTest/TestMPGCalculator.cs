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
            MPG instanceOne = new MPG(300, 10);
            MPG instanceTwo = new MPG(400, 20);

            // act and assert
            Assert.AreEqual(300, instanceOne.Miles, .00);
            Assert.AreEqual(10, instanceOne.Gallons, .00);
            Assert.AreEqual(30, instanceOne.Mpg, .00);

            Assert.AreEqual(400, instanceTwo.Miles, .00);
            Assert.AreEqual(20, instanceTwo.Gallons, .00);
            Assert.AreEqual(20, instanceTwo.Mpg, .00);

            Assert.AreEqual(700, MPG.TotalMiles, .00);
            Assert.AreEqual(30, MPG.TotalGallons, .00);
            Assert.AreEqual(23.33, MPG.TotalMPG, .01);
            Assert.AreEqual(2, MPG.NumTrips);
        }
    }
}
