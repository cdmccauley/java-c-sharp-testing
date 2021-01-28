using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShippingCostsTest
{
    [TestClass]
    public class TestShippingCosts
    {
        public const double DELTA = 0.00;

        [TestMethod]
        public void ItSetsInvalidPropertiesToNull()
        {
            ShippingCosts.Package testObject = new ShippingCosts.Package(-1.0, -1.0);
            Assert.AreEqual(null, testObject.Distance);
            Assert.AreEqual(null, testObject.Weight);
        }

        [TestMethod]
        public void ItSetsValidPropertiesToDouble()
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

        [DataTestMethod]
        [DataRow(9.9, 2.5, DELTA)]
        [DataRow(10.0, 10.0, DELTA)]
        [DataRow(24.9, 10.0, DELTA)]
        [DataRow(25.0, 25.0, DELTA)]
        public void ItReturnsCorrectWeightFactor(double weight, double expected, double delta)
        {
            double placeholderDistance = 0.1;
            ShippingCosts.Package testObject = new ShippingCosts.Package(placeholderDistance, weight);
            Assert.AreEqual(expected, testObject.getWeightFactor(), delta);
        }

        [DataTestMethod]
        [DataRow(99.9, 2.0, DELTA)]
        [DataRow(100.0, 5.0, DELTA)]
        [DataRow(499.9, 5.0, DELTA)]
        [DataRow(500.0, 10.0, DELTA)]
        public void ItReturnsCorrectDistanceFactor(double distance, double expected, double delta)
        {
            double placeholderWeight = 0.1;
            ShippingCosts.Package testObject = new ShippingCosts.Package(distance, placeholderWeight);
            Assert.AreEqual(expected, testObject.getDistanceFactor(), delta);
        }

        [DataTestMethod]
        [DataRow(99.9, 9.9, 5.0, DELTA)]
        [DataRow(499.9, 9.9, 12.50, DELTA)]
        [DataRow(500.0, 9.9, 25.0, DELTA)]
        [DataRow(99.9, 24.9, 20.0, DELTA)]
        [DataRow(499.9, 24.9, 50.0, DELTA)]
        [DataRow(500.0, 24.9, 100.0, DELTA)]
        [DataRow(99.9, 25.0, 50.0, DELTA)]
        [DataRow(499.9, 25.0, 125.0, DELTA)]
        [DataRow(500.0, 25.0, 250.0, DELTA)]
        public void ItReturnsCorrectCost(double distance, double weight, double expected, double delta)
        {
            ShippingCosts.Package validTestOjbect = new ShippingCosts.Package(distance, weight);
            Assert.AreEqual(expected, validTestOjbect.cost(), delta);
        }

        [TestMethod]
        [ExpectedException(typeof(ShippingCosts.Package.InvalidPackageException))]
        public void ItThrowsWhenInvalidCost()
        {
            ShippingCosts.Package invalidTestOjbect = new ShippingCosts.Package(-1.0, -1.0);
            invalidTestOjbect.cost();
        }
    }
}
