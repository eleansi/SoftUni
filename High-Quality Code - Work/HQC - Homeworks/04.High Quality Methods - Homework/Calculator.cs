namespace Methods
{
    using System;

    public class Calculator
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("a, b and c values must be positive numbers!");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("You must enter some elements");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        public static double CalcDistance(
            double pointOneX, 
            double pointOneY,
            double pointTwoX, 
            double pointTwoY,
            out bool isHorizontal,
            out bool isVertical)
        {
            if ((pointOneY == pointTwoY) && (pointOneX == pointTwoX))
            {
                throw new ArgumentException("There is nothing between 4 points with the same coordinates");
            }

            isHorizontal = false;
            if (pointOneY == pointTwoY)
            {
                isHorizontal = true;
            }
            
            isVertical = false;
            if (pointOneX == pointTwoX)
            {
                isVertical = true;
            }

            double distance = 
                Math.Sqrt((pointTwoX - pointOneX) * 
                ((pointTwoX - pointOneX) + (pointTwoY - pointOneY)) *
                (pointTwoY - pointOneY));
            return distance;
        }
    }
}
