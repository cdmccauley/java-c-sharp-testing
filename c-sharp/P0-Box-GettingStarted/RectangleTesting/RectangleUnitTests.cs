using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Rectangle;

namespace RectangleTesting
{
    [TestClass]
    public class RectangleUnitTests
    {
        [TestMethod]
        public void TestPerimeter()
        {
            // create an object of the Box class
            Rectangle.Box testObj = new Rectangle.Box(12, 8);
            // declare the expected result for the perimeter
            int expectedResult = 40;
            // get the actual result by calling the method
            int actualResult = testObj.calcPerimeter();
            // compare actual and expected results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestArea()
        {
            Rectangle.Box testObj = new Rectangle.Box(12, 8);
            int expectedResult = 960;
            int actualResult = testObj.calcArea();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}


