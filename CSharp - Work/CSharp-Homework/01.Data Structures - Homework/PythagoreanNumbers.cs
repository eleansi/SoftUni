using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        bool matchFound = false;
        for (int indexOne = 0; indexOne < numbers.Length; indexOne++)
        {
            for (int indexTwo = 0; indexTwo < numbers.Length; indexTwo++)
            {
                for (int indexThree = 0; indexThree < numbers.Length; indexThree++)
                {
                    int a = numbers[indexOne];
                    int b = numbers[indexTwo];
                    int c = numbers[indexThree];
                    if (a <= b && (a * a) + (b * b) == (c * c)) 
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                    }
                }
            }
        }
        if (!matchFound)
        {
            Console.WriteLine("No");
        }

    }
}
