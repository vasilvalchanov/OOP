using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    using System.IO;

    using Problem1Point3D;

    using Problem2DistanceCalculator;

    public class PathsMain
    {
        static void Main(string[] args)
        {
            Point3D start = Point3D.StartingCoords;
            Point3D a = new Point3D(1, 1, 1);
            Point3D b = new Point3D(2, 2, 3);
            double distanceStartA = DistanceCalculator.CalculateTheDistance(start, a);
            double distanceStartB = DistanceCalculator.CalculateTheDistance(start, b);
            Path3D first = new Path3D(start, a);
            Path3D second = new Path3D(start, a, b);
            Storage.SavePath(first, "pathFirst.txt");
            Storage.SavePath(second, "pathSecond.txt");

            try
            {
                Path3D loadedFirst = Storage.LoadPath("pathFirst.txt");
                foreach (Point3D point in loadedFirst.Points)
                {
                    Console.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
