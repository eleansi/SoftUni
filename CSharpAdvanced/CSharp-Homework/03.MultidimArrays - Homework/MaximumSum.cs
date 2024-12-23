using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximumSum
{
    static void Main(string[] args)
    {
        // Input
        string[] matrixSize = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(matrixSize[0]);
        int m = int.Parse(matrixSize[1]);
        int[,] matrix = new int[n, m];
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] matrixNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(matrixNumbers[col]);
            }   
        }
        // End of Input

        // Extract the area 3x3
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
            {
                currentSum = matrix[rows, cols] +
                             matrix[rows, cols + 1] +
                             matrix[rows, cols + 2] +
                             matrix[rows + 1, cols] +
                             matrix[rows + 1, cols + 1] +
                             matrix[rows + 1, cols + 2] +
                             matrix[rows + 2, cols] +
                             matrix[rows + 2, cols + 1]+
                             matrix[rows + 2, cols + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = rows;
                    bestCol = cols;
                }
            }
        }

        //Printing the area and sum
        Console.WriteLine("Sum = {0}", bestSum);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        
    }
}

