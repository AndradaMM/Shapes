using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Rectangle : Quadrilateral
    {
        public Rectangle(double sideLenght, double width) : base(sideLenght)
        {
            Width = width;
        }

        public double Width { get; set; }

        

        public override double CalculateArea()
        {
            return SideLenght * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (SideLenght + Width);
        }
    }
}
