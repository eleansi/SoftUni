using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.UppercaseWords
{
    class UpperCaseWords
    {
        static void Main(string[] args)
        {
            StringBuilder line = new StringBuilder(Console.ReadLine());
            while (line.ToString() != "END")
            {
                Regex regex = new Regex(@"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])");
                MatchCollection matches = regex.Matches(line.ToString());

                int offset = 0;
                foreach (Match match in matches)
                {
                    string word = match.Value;
                    string reversed = Reversed(word);


                    if (reversed == word)
                    {
                        reversed = DoubleLetter(reversed);
                    }

                    int index = match.Index;
                    line.Remove(index + offset, word.Length);
                    line.Insert(index + offset, reversed);
                    offset += reversed.Length - word.Length;
                }
                Console.WriteLine(SecurityElement.Escape(line.ToString()));
                line = new StringBuilder(Console.ReadLine());
            }
        }

        private static string DoubleLetter(string reversed)
        {
            StringBuilder doubled = new StringBuilder();
            for (int i = 0; i < reversed.Length; i++)
            {
                doubled.Append(new string(reversed[i], 2));
            }
            return doubled.ToString();
        }

        private static string Reversed(string value)
        {
            StringBuilder reverse = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reverse.Append(value[i]);
            }
            return reverse.ToString();
        }
    }
}
