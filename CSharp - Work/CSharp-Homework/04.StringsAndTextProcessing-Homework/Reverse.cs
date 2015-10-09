using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char[] reverse = inputLine.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
    }
}
