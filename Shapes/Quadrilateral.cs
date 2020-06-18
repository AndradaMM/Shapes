using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Quadrilateral : IShape
    {

        public double SideLenght { get; set; }
        public abstract double CalculateArea();

        protected Quadrilateral(double sideLenght)
        {
            SideLenght = sideLenght;
        }

        public virtual double CalculatePerimeter()
        {
            return 4 * SideLenght;
        }

        public int NumberOfSides()
        {
            return 4;
        }


    }
}
