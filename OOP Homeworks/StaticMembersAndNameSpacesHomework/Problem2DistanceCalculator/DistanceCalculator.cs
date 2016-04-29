using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2DistanceCalculator
{
    using Problem1Point3D;

    public static class DistanceCalculator
    {
        public static double CalculateTheDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance =
                Math.Sqrt(
                    Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2)
                    + Math.Pow(secondPoint.Z - firstPoint.Z, 2));

            return distance;
        }
    }
}
