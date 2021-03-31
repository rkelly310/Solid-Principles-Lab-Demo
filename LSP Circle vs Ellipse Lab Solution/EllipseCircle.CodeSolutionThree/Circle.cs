using System;
using System.Collections.Generic;
using System.Text;

namespace EllipseCircle.CodeSolutionThree
{
    public class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return this.radius * this.radius * Math.PI;
        }
    }
}

