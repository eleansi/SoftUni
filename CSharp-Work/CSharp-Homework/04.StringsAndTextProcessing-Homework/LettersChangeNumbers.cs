using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < inputLine.Length; i++)
            {
                string input = inputLine[i];
                char letterBefore = input[0];
                char letterAfter = input[input.Length - 1];
                double number = double.Parse(input.Substring(1, input.Length - 2));

                if (char.IsUpper(letterBefore)) //-------------------- In case letter before number is Capital
                {
                    int beforePosition = letterBefore - 'A' + 1;
                    number = number / beforePosition;
                }

                if (char.IsLower(letterBefore)) // -------------------- In case letter before the number is minuscule
                {
                    int beforePosition = letterBefore - 'a' + 1;
                    number = number * beforePosition;
                }

                if (char.IsLower(letterAfter)) // ---------------------- In case letter after is minuscule
                {
                    int afterPosition = letterAfter - 'a' + 1;
                    number = number + afterPosition;
                }

                if (char.IsUpper(letterAfter)) // --------------------- In case letter after is Capital
                {
                    int afterPosition = letterAfter - 'A' + 1;
                    number = number - afterPosition;
                }
                sum = sum + number;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
