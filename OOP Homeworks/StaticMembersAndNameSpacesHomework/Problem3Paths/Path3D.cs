using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    using Problem1Point3D;

    public class Path3D
    {
        private List<Point3D> points;

        public Path3D(params Point3D[] points)
        {
            this.points = new List<Point3D>();
            this.addPoints(points);
        }
        private void addPoints(params Point3D[] points)
        {
            if (points.Length < 2)
            {
                throw new ArgumentException("Path should have at least 2 Points3D");
            }
            this.points.AddRange(points);
        }

        public IEnumerable<Point3D> Points
        {
            get
            {
                return this.points;
            }
        }
    }
}
