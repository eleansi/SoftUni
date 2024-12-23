namespace Methods
{
    using System;

    public class Formatter
    {
        public static string ConvertingNumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                //// Instead of returning "Invalid number" after the switch case, we can better make it 
                //// as a default value of the switch and return it if the user don't enter a number from 0 to 9
                default:
                    return "Invalid number";
            }
            ////return "Invalid number!";
        }

        public static void FormatNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
    }
}
