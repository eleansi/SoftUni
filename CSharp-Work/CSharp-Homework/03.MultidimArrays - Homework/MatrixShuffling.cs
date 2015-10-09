using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixShuffling
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); 
        int m = int.Parse(Console.ReadLine()); 
        string[,] matrix = new string[n, m];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (command[0] != "END")
        {
            if (command[0] == "swap")
            {
                
                int x1 = int.Parse(command[1]);
                int y1 = int.Parse(command[2]);
                int x2 = int.Parse(command[3]);
                int y2 = int.Parse(command[4]);

                
                if (x1 > matrix.GetLength(0) || y1 > matrix.GetLength(1) || x2 > matrix.GetLength(0) || y2 > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    SwapCommand(matrix, x1, y1, x2, y2);
                    PrintMatrix(matrix);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
        }
    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
    static void SwapCommand(string[,] matrix, int x1, int y1, int x2, int y2) 
    {

        string temp1 = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = temp1;
    }
}

