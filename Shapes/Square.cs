using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Square : Quadrilateral
    {
        public Square(double sideLenght) : base(sideLenght)
        {
        }

        public override double CalculateArea()
        {
            return Math.Pow(SideLenght, 2);
        }
    }
}
