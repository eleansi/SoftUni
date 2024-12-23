using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = Int32.Parse(Console.ReadLine());
            int end = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                start = ReadNumber(start, end);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int number;
            try
            {
                Console.WriteLine("Enter number < {0} your number < {1}: ", start, end);
                number = Int32.Parse(Console.ReadLine());
                while (!(start < number && number < end))
                {
                    Console.WriteLine("Your number is not in range {0} - {1}", start, end);
                    Console.WriteLine("Enter number < {0} your number < {1}: ", start, end);
                    number = Int32.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
                throw;
            }

            return number;
        }
    }
}
