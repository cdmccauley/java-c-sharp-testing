using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomNumbersTest
{
    [TestClass]
    public class TestRandomNumbers
    {
        [TestMethod]
        public void TestgetRNRange()
        {
            for (int i = 0; i < 5000; i++)
            {
                int testValue = RandomNumbers.Program.getRN(20, 29);
                Assert.IsTrue(testValue >= 20 && testValue <= 29, $"Value was {testValue}");
            }
        }

        [TestMethod]
        public void TestgetRNMin()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(20, RandomNumbers.Program.getRN(20, 20));
            }
        }

        [TestMethod]
        public void TestgetRNMax()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(29, RandomNumbers.Program.getRN(29, 29));
            }
        }
    }
}
