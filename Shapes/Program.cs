using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Square(10), 
                new Rectangle(5, 7),
                new Trapezoid(15, 5, 4, 7, 9),
                new EquilateralTriangle(5)
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine($"Type is: {shape.GetType().Name}");
                Console.WriteLine($"Area is: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter is: {shape.CalculatePerimeter()}");
            }
            Console.WriteLine();
            //casting
            foreach(var shape in shapes)
            {
                if(shape is Rectangle)
                {
                    var rectangle = (Rectangle)shape;
                    Console.WriteLine($"Rectangle width: {rectangle.Width}");
                }
            }


            Console.ReadKey();
        }
    }
}
