using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
            LargerNeighbours(inputNumbers);
            
        }

        static void LargerNeighbours(int[] numbers) 
        {
            bool isBigger = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    isBigger = (numbers[i] > numbers[i - 1]);
                    Console.WriteLine(isBigger);
                    return;
                }
                isBigger = false;
                if (i == 0 && numbers[i] > numbers[i + 1])
                {
                    isBigger = true;
                }

                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    isBigger = true;

                }
                else
                {
                    isBigger = false;
                }
                Console.WriteLine(isBigger);
            }
        }   
     }
}
