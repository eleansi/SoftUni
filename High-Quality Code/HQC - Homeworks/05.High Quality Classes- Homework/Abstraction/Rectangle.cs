namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        /// <summary>
        /// This method calculates the perimeter of a rectangle.
        /// </summary>
        /// <returns>Perimeter of the rectangle</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// This method calculates the surface of a rectangle.
        /// </summary>
        /// <returns>Surface of a rectangle</returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
