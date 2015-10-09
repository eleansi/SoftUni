using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            // Input Line
            string[] input = Console.ReadLine().Split(new char[] { ',', ';', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            // Storing data
            List<string> reversedData = new List<string>();

            // Going through the Input
            for (int i = 0; i < input.Length; i++)
            {
                
                string reverse = PerformingReversion(input[i]);
                if (input[i] == reverse)
                {
                    reversedData.Add(input[i]);
                }
            }
            reversedData.Sort();
            Console.WriteLine(string.Join(", ", reversedData));
        }
        //Reversion algorithm
        static string PerformingReversion(string reversing) 
        {
            char[] array = reversing.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
