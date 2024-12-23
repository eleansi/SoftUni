using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SeriesofLetters
{
    class Series
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Regex regex = new Regex(@"(.)\1+");
            Console.WriteLine(regex.Replace(inputLine, "$1"));
        }
    }
}
