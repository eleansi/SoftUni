using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class Filter
    {
        static void Main(string[] args)
        {
            string[] wordsToBeBanned = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder censoredText = new StringBuilder(Console.ReadLine());
            
            string[] bannedSymbols = new string[wordsToBeBanned.Count()];
            for (int i = 0; i < wordsToBeBanned.Count(); i++)
            {
                bannedSymbols[i] = new string('*', wordsToBeBanned[i].Count());
                censoredText.Replace(wordsToBeBanned[i], bannedSymbols[i]);
            }
            Console.WriteLine();
            Console.WriteLine(censoredText);
        }
    }
}
