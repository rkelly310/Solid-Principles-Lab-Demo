using System;
using System.Collections.Generic;
using System.Text;

namespace EllipseCircle.CodeSolutionThree
{
    public interface IShape
    {
        double Area();
    }

    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }

}
