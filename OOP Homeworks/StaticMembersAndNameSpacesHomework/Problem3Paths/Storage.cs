using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    using System.IO;

    using Problem1Point3D;

    public static class Storage
    {
        public static void SavePath(Path3D path, String filePath)
        {
            Stream file = File.Create(filePath);
            StreamWriter writer = new StreamWriter(file);
            using (writer)
            {

                foreach (Point3D point in path.Points)
                {
                    writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
        }
        public static Path3D LoadPath(String filename)
        {
            List<Point3D> points = new List<Point3D>();
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                while (true)
                {
                    String line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    int[] coordinates = line.Split(' ').Select(int.Parse).ToArray();
                    int x = coordinates[0];
                    int y = coordinates[1];
                    int z = coordinates[2];
                    points.Add(new Point3D(x, y, z));
                }
            }
            Path3D path = new Path3D(points.ToArray());
            return path;
        }
    }
}
