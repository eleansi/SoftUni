using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            Regex pairMatcher = new Regex(@"(\D+)(\d+)");
            string input = Console.ReadLine();
            Match pair = pairMatcher.Match(input);
            StringBuilder result = new StringBuilder();

            do
            {
                string str = pair.Groups[1].Value.ToUpper();
                int count = int.Parse(pair.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(str);
                }
                pair = pair.NextMatch();
            } while (pair.Success);

            int uniqueSymbol = result.ToString().Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}", uniqueSymbol);
            Console.WriteLine(result);
        }
    }
}
