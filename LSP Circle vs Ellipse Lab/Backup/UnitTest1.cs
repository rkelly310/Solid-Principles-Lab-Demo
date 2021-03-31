using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EllipseCircle.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circle circle = new Circle();
            circle.SetMajorAxis(5);
            circle.SetMinorAxis(4);
        }
    }
}
