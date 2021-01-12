using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingCostsTest
{
    [TestClass]
    public class TestShippingCosts
    {
        [TestMethod]
        public void ItSetsPropertiesToNull()
        {
            ShippingCosts.Package testObject = new ShippingCosts.Package(-1.0, -1.0);
            Assert.AreEqual(null, testObject.Distance);
            Assert.AreEqual(null, testObject.Weight);
        }

        [TestMethod]
        public void ItSetsPropertiesToDouble()
        {
            double testDistance = 1.0;
            double testWeight = 1.0;
            ShippingCosts.Package testObject = new ShippingCosts.Package(testDistance, testWeight);
            Assert.AreEqual(testDistance, testObject.Distance);
            Assert.AreEqual(testWeight, testObject.Weight);
        }

        [TestMethod]
        public void ItReturnsInvalid()
        {
            ShippingCosts.Package testObject = new ShippingCosts.Package(-1.0, -1.0);
            Assert.IsFalse(testObject.isValid());
        }

        [TestMethod]
        public void ItReturnsValid()
        {
            ShippingCosts.Package testObject = new ShippingCosts.Package(1.0, 1.0);
            Assert.IsTrue(testObject.isValid());
        }

        [TestMethod]
        public void ItReturnsCorrectCost()
        {
            ShippingCosts.Package validTestOjbect = new ShippingCosts.Package(1.0, 1.0);
            Assert.AreEqual(0.0, validTestOjbect.cost());
        }

        [TestMethod]
        [ExpectedException(typeof(ShippingCosts.Package.InvalidPackageException))]
        public void ItThrowsWhenCallingCost()
        {
            ShippingCosts.Package invalidTestOjbect = new ShippingCosts.Package(-1.0, -1.0);
            invalidTestOjbect.cost();
        }
    }
}
