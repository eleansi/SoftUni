using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<List<string>> firstJaggedArray = ReadJaggedArray(n);
        List<List<string>> secondJaggedArray = ReadJaggedArray(n);

        bool canFit = true;
        int rowColSum = firstJaggedArray[0].Count + secondJaggedArray[0].Count;
        for (int i = 1; i < n; i++)
        {
            if (firstJaggedArray[i].Count + secondJaggedArray[i].Count != rowColSum)
            {
                canFit = false;
                break;
            }
        }

        if (canFit)
        {
            for (int i = 0; i < n; i++)
            {
                secondJaggedArray[i].Reverse();
                firstJaggedArray[i].AddRange(secondJaggedArray[i]);
                Console.WriteLine("[{0}]", String.Join(", ", firstJaggedArray[i]));
            }
        }
        else
        {
            int totalNumberOfCells = 0;
            for (int i = 0; i < n; i++)
            {
                totalNumberOfCells += firstJaggedArray[i].Count;
                totalNumberOfCells += secondJaggedArray[i].Count;
            }
            Console.WriteLine("The total number of cells is: {0}", totalNumberOfCells);
        }
        
    }

    private static List<List<string>> ReadJaggedArray(int n)
    {
        List<List<string>> jaggedArray = new List<List<string>>();

        string inputLine = String.Empty;
        string[] tokens;
        for (int row = 0; row < n; row++)
        {
            jaggedArray.Add(new List<string>());
            inputLine = Console.ReadLine();
            tokens = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < tokens.Length; col++)
            {
                jaggedArray[row].Add(tokens[col]);
            }
        }
        return jaggedArray;
    }
}

