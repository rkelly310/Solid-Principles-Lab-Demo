using System;
using System.Collections.Generic;
using System.Text;

namespace EllipseCircle.CodeSolutionOne
{
    public class CircleRevised : Ellipse
    {
        public override void SetMajorAxis(double majorAxis)
        {
            base.SetMajorAxis(majorAxis);
            this.MinorAxis = majorAxis; //In a cirle, each axis is identical
        }

        public override void SetMinorAxis(double minorAxis)
        {
            base.SetMinorAxis(minorAxis);
            this.MajorAxis = minorAxis;
        }

        public override double Area()
        {
            return base.Area();
        }
    }
}
