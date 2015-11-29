using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Problem1_Point3D
    {
        private static readonly Problem1_Point3D startingPoint = new Problem1_Point3D(0, 0, 0);

        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;

       
        
        public Problem1_Point3D(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }

       

        public double CoordinateX
        {
            get { return this.coordinateX; }
            set { this.coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return this.coordinateY; }
            set { this.coordinateY = value; }
        }

        public double CoordinateZ
        {
            get { return this.coordinateZ; }
            set { this.coordinateZ = value; }
        }

        public static Problem1_Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            return String.Format("Point X = {0}, Point Y = {1}, Point Z = {2}", 
                this.coordinateX, 
                this.coordinateY, 
                this.coordinateZ);
        }
    }
}
