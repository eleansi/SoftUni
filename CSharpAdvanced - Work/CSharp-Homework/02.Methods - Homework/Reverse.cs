using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class Reverse
    {
        static void Main(string[] args)
        {
            double reversed = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversed(reversed));
        }

        static double GetReversed(double num) 
        {
            string number = num.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string reverseNumber = new string(reverse);
            double newNumber = double.Parse(reverseNumber);
            return newNumber;
        }
    }
}
