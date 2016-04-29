using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingCoords = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Point3D StartingCoords
        {
            get
            {
                return startingCoords;
            }
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }
    }
}
