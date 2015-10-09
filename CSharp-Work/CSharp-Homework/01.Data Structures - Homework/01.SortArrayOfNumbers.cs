using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        int[] numbers = inputLine.Split().Select(int.Parse).ToArray();
        Array.Sort(numbers);
        foreach (var num in numbers)
        {
            Console.WriteLine(num + " ");
        }
    }
}

