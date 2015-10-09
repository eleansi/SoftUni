using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        for (int i = 0; i < input.Length - 1; i++)
        {
            Console.Write(input[i] + " ");
            if (!input[i].Equals(input[i + 1]))
            {
                Console.WriteLine();
            }
        }
        Console.Write(input[input.Length - 1]);
        Console.WriteLine();
    }
}

