using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Problem2_DistanceCalc
    {
        public static double CalculateDistance(Problem1_Point3D p1, Problem1_Point3D p2)
        {
            double deltaX = Math.Pow(p1.CoordinateX - p2.CoordinateX, 2);
            double deltaY = Math.Pow(p1.CoordinateY - p2.CoordinateY, 2);
            double deltaZ = Math.Pow(p1.CoordinateZ - p2.CoordinateZ, 2);

            return Math.Sqrt(deltaX + deltaY + deltaZ);
        }
    }
}
