using System;

namespace EllipseCircle.CodeSolutionThree
{
    public class Ellipse : IShape
    {
        double MajorAxis;
        double MinorAxis;

        public Ellipse(double MajorAxis, double MinorAxis)
        {
            this.MajorAxis = MajorAxis;
            this.MinorAxis = MinorAxis;
        }

        public double Area()
        {
            return MajorAxis * MinorAxis * Math.PI;
        }
    }
}
