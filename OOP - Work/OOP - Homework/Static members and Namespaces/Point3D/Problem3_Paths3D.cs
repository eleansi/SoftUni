using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Point3D
{
    public class Problem3_Paths3D
    {
        private readonly double distance;
        private List<Problem1_Point3D> points;

        public Problem3_Paths3D(List<Problem1_Point3D> points)
        {
            this.points = points;
            this.distance = calcDistance(this.points);
        }

        public double Distance
        {
            get { return this.distance; }
        }

        private double calcDistance(List<Problem1_Point3D> point3D)
        {
            double distanceBetweenPoints = 0.0;
            for (int i = 0; i < point3D.Count - 1; i++)
            {
                distanceBetweenPoints += Problem2_DistanceCalc.CalculateDistance(point3D[i], point3D[i + 1]);
            }
            return distanceBetweenPoints;
        }

        public override string ToString()
        {
            string path = String.Empty;

            for (int i = 0; i < points.Count; i++)
            {
                path += "Point" + i + 1 + " coordinates: " + points[i].CoordinateX + ", " + points[i].CoordinateY + ", " +
                        points[i].CoordinateZ + Environment.NewLine;
            }

            path += "Distance between points: " + this.Distance + Environment.NewLine + Environment.NewLine;
            return path;
        }
    }
}
