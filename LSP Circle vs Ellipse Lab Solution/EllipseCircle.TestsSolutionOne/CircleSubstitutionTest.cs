using EllipseCircle.CodeSolutionOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EllipseCircle.TestsSolutionOne
{
    [TestClass]
    public class CircleSubstitutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ellipse circle = new CircleRevised(); //Since they are subject to inheritance, we can substitute a Circle for an Ellipse object and still pass this test.
            circle.SetMajorAxis(5);
            Assert.AreEqual(5*5*Math.PI, circle.Area());
        }
            //Notice that we have changed our 'Circle' class to a CircleRevised class that implements the SetMinorAxis method,
            //therefore bypassing the issue as long as we don't invoke that method. This code now follows the LSP.
    }
}