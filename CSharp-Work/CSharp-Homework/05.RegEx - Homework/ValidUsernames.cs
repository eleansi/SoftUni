using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().Trim();
            string[] usernames = Regex.Split(inputLine, @"[\s/\\\(\)\,]+");
            List<string> validUsernames = new List<string>();

            string validUsernamePattern = @"^[A-Za-z]\w+$";
            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 25 && Regex.IsMatch(username, validUsernamePattern))
                {
                    validUsernames.Add(username);
                }
            }

            int maxSum = -1;
            int currentSum = -1;
            int maxSumIndex = -1;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                currentSum = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumIndex = i;
                }
            }
            Console.WriteLine("{0}\n{1}", validUsernames[maxSumIndex], validUsernames[maxSumIndex + 1]);
        }
    }
}
