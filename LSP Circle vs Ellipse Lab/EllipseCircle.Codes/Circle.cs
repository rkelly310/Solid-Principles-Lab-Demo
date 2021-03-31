using System;
using System.Collections.Generic;
using System.Text;

namespace EllipseCircle.Code
{
    public class Circle : Ellipse
    {
        public override void SetMajorAxis(double majorAxis)
        {
            base.SetMajorAxis(majorAxis);
            this.MinorAxis = majorAxis; //In a cirle, each axis is identical
        }
    }
}
