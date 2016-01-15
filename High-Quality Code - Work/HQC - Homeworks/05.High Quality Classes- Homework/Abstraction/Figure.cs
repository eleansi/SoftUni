namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;

        private double height;

        private double radius;

        protected Figure()
        {
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Figure width
        /// </summary>
        public virtual double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width can't be negative numberand zero either.");
                }
                this.width = value;
            }
        }

        /// <summary>
        /// Figure height
        /// </summary>
        public virtual double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width can't be negative numberand zero either.");
                }
                this.height = value;
            }
        }

        /// <summary>
        /// Figure radius
        /// </summary>
        public virtual double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width can't be negative numberand zero either.");
                }
                this.radius = value;
            }
        }

        public abstract double CalcSurface();

        public abstract double CalcPerimeter();
    }
}
