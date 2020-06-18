using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Trapezoid : Quadrilateral
    {
        public Trapezoid(double sideLenght, double height, double smallSlideLenght, double leftSlideLenght, double rightSlideLenght) : base(sideLenght)
        {
            Height = height;
            SmallSlideLenght = smallSlideLenght;
            LeftSlideLenght = leftSlideLenght;
            RightSlideLenght = rightSlideLenght;
        }

        public double Height { get; set; }
        public double SmallSlideLenght { get; set; }
        public double LeftSlideLenght { get; set; }
        public double RightSlideLenght { get; set; }
        public override double CalculateArea()
        {
            return (SideLenght + SideLenght) * Height / 2;
        }

        public override double CalculatePerimeter()
        {
            return SmallSlideLenght + LeftSlideLenght + RightSlideLenght + SideLenght;
        }

    }
}
