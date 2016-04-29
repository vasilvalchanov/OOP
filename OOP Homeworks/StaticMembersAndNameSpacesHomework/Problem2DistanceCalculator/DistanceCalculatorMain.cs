using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2DistanceCalculator
{
    using Problem1Point3D;

    public class DistanceCalculatorMain
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point3D(5, 6, 2);
            var secondPoint = new Point3D(-7, 11, -13);

            double distance = DistanceCalculator.CalculateTheDistance(firstPoint, secondPoint);

            Console.WriteLine("Distance = {0:F2}", distance);
        }
    }
}
