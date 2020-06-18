using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class EquilateralTriangle : IShape
    {
        public double SideLenght { get; set; }

        public EquilateralTriangle(double sideLenght)
        {
            SideLenght = sideLenght;
        }

        public double CalculateArea()
        {
            return (Math.Pow(SideLenght, 2) * Math.Sqrt(3)) / 4;
        }

        public double CalculatePerimeter()
        {
            return 3 * SideLenght;
        }
    }
}
