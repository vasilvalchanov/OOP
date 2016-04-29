using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Point3D
{
    public class Point3DMain
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(2, 5, 6);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingCoords);
        }
    }
}
