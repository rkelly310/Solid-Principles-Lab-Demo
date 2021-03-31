using EllipseCircle.CodeSolutionTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EllipseCircle.TestsSolutionTwo
{
    [TestClass]
    public class CircleSubstitutionTestIsolated
    {
        [TestMethod]
        public void TestMethod1()
        {
            CircleIsolated circle = new CircleIsolated();
            circle.SetRadius(5);
            Assert.AreEqual(5*5*Math.PI, circle.Area());
        }
            //This Alternative solution isolates the Circle class and gives it separate logic entirely from the Ellipse class, therefore
            //removing the need for inheriting a 'SetMinorAxis' method in the CircleRevised class since it is unused. This solution avoids substitution entirely.
    }
}