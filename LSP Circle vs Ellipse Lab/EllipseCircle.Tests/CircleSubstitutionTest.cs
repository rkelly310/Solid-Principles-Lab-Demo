using EllipseCircle.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EllipseCircle.Tests
{
    [TestClass]
    public class CircleSubstitutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circle circle = new Circle();
            circle.SetMajorAxis(5);
            circle.SetMinorAxis(4);
            Assert.AreEqual(5 * 5 * Math.PI, circle.Area()); 
            //Our 'Circle' class notes that the Major and Minor axes should be the same, so 5*5 equals 25.
            //For some reaon the Area() funnction returns the wrong answer for the circle object with a radius of 5.
            //Why does this test fail?
            //Rewrite the Circle and/or Ellipse classes to comply with the Liskov Substitution Principle.
        }
    }
}
