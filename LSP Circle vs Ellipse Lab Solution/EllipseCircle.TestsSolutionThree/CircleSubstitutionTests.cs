using EllipseCircle.CodeSolutionThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EllipseCircle.TestsSolutionThree
{
    [TestClass]
    public class CircleSubstitutionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ellipse ellipse = new Ellipse(5, 4); //Initializing an 'ellipse' object with values 
            Assert.AreEqual(5 * 4 * Math.PI, ellipse.Area());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Circle circle = new Circle(6); //Since we declared the 'Area' method in the Interface 'IShape', it can now be called with different logic for different objects.
            Assert.AreEqual(6 * 6 * Math.PI, circle.Area());
        }


        //===============================================================================================================================================================================

        [TestMethod]
        public void TestMethod3()
        {
            AreaCalculator newshape = new AreaCalculator();
            Assert.AreEqual(5 * 5 * Math.PI, newshape.CalculateArea(new Circle(5)));
        }

        [TestMethod]
        public void TestMethod4()
        {
            AreaCalculator newshape = new AreaCalculator();
            Assert.AreEqual(5 * 6 * Math.PI, newshape.CalculateArea(new Ellipse(5, 6)));
            //This solution goes beyond to make both the Ellipse and the Circle classes implement a 'Shape' interface that declares the 'Area' method.
            //We also have the end client (AreaCalculator) that can never know what type it is being created for; it only knows that a shape is being passed.
            //This way, the classes are all loosely coupled and compliant with the LSP, OCP, SRP, ISP and DIP.
        }
    }
}