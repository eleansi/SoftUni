using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {

        // Matrix A
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = counter;
                ++counter;
            }
        }
        PrintMatrix(matrix);



        Console.WriteLine("-----------------------------------------------------------------");
        // Matrix B
        n = int.Parse(Console.ReadLine());
        counter = 0;
        matrix = new int[n, n];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                counter++;
                if (row % 2 == 0)
                {
                    matrix[col, row] = counter;
                }
                else
                {
                    matrix[matrix.GetLength(0) - col - 1, row] = counter;
                }
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix) 
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
 }

