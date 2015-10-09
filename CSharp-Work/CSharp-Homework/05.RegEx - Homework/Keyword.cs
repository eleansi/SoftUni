using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Keyword
{
    class Keyword
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine().Trim();
            keyword = @"\b" + keyword + @"\b";
            string text = Console.ReadLine();
            string textPattern = @"[A-Z][A-Za-z\s\-\,\:\'u2019u2013]*[\?\!\.\:\)]";
            Regex regex = new Regex(textPattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string sentence = match.Value;
                if (Regex.IsMatch(sentence, keyword))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
