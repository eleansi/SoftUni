namespace CohesionAndCoupling
{
    using System;

    public class DistanceCalculator
    {
        private double width;

        private double height;

        private double depth;

        public DistanceCalculator(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Width cannot be negative number or zero");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Height cannot be negative number or zero");
                }
                this.height = value;
            }
        }

        public double Depth
        {
            get { return this.depth; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Depth cannot be negative number or zero");
                }
                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = PointLocator.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public  double CalcDiagonalXY()
        {
            double distance = PointLocator.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = PointLocator.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = PointLocator.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
