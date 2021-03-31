using System;
using System.Collections.Generic;
using System.Text;

namespace EllipseCircle.CodeSolutionTwo
{
    public class CircleIsolated
    {
        public double Radius { get; set; }
        public void SetRadius(double radius)
        {
            this.Radius = radius;
        }

        public double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
