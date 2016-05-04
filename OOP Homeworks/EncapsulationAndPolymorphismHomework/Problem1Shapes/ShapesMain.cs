using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Shapes
{
    class ShapesMain
    {
        static void Main(string[] args)
        {
            var shapes = new IShape[3];
            shapes[0] = new Rectangle(4.5, 2.3);
            shapes[1] = new Rhombus(3.3, 3.8);
            shapes[2] = new Circle(5);

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}", shape.GetType().Name);
                Console.WriteLine("Area: {0:F2}", shape.CalculateArea());
                Console.WriteLine("Perimeter: {0:F2}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
