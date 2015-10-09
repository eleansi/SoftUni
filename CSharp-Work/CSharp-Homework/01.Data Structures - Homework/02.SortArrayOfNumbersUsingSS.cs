using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSS
{
    static int[] numbers;

    static void Main()
    {
        string input = Console.ReadLine();
        numbers = input.Split().Select(int.Parse).ToArray();

        
        Console.WriteLine("Seltection Sort");
        SelectionSort();
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] SelectionSort()
    {
        for (int a = 0; a < numbers.Length - 1; a++)
        {
            int minValue = a;
            for (int b = a + 1; b < numbers.Length; b++)
            {
                if (numbers[b] < numbers[minValue])
                {
                    minValue = b;
                }
            }
            int temp = numbers[a];
            numbers[a] = numbers[minValue];
            numbers[minValue] = temp;
        }
        return numbers;
    }
}

