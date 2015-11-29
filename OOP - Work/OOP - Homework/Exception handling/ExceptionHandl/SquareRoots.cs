using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandl
{
    class SquareRoots
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("Square root from {0} is {1}", number, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.WriteLine("Number should be positive!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
