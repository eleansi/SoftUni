using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();
        string[] numbersAsStrings = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numbersAsStrings.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }
        bool matchFound = false;
        for (int indexOne = 0; indexOne < numbers.Length; indexOne++)
        {
            for (int indexTwo = 0; indexTwo < numbers.Length; indexTwo++)
            {
                for (int indexThree = 0; indexThree < numbers.Length; indexThree++)
                {
                    for (int indexFour = 0; indexFour < numbers.Length; indexFour++)
                    {
                        int a = numbers[indexOne];
                        int b = numbers[indexTwo];
                        int c = numbers[indexThree];
                        int d = numbers[indexFour];
                        if (a != b && a != c && a != d && b != c && b != d && c != d && 
                            (numbersAsStrings[indexOne] + 
                            numbersAsStrings[indexTwo])
                            .Equals(numbersAsStrings[indexThree]
                            + numbersAsStrings[indexFour]))
                        {
                            Console.WriteLine("{0}|{1} == {2}|{3}", a, b, c, d);
                            matchFound = true;
                        }
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

