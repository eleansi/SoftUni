using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ContSubstrings
{
    class CountSubStr
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine();
            int counterForSubstring = 0;
            int position = str.IndexOf(subStr);
            while (position >= 0 && position <= str.Length)
            {
                counterForSubstring++;
                position = str.IndexOf(subStr, position + 1);
            }
            Console.WriteLine(counterForSubstring);
        }
    }
}
