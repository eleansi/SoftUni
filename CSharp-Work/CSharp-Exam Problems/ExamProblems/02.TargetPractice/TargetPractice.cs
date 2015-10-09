using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int numberOfRows = int.Parse(dimensions[0]);
            int numberOfCols = int.Parse(dimensions[1]);
            char[,] matrix = new char[numberOfRows, numberOfCols];
            string snake = Console.ReadLine();
            bool isMovingLeft = true;
            int currentIndex = 0;

            FillMatrix(numberOfRows, numberOfCols, matrix, snake, isMovingLeft, currentIndex);

            string[] shotArguments = Console.ReadLine().Split(' ');
            int impactRow = int.Parse(shotArguments[0]);
            int impactCol = int.Parse(shotArguments[1]);
            int radius = int.Parse(shotArguments[2]);

            FireAShot(matrix, impactRow, impactCol, radius);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                RunGravity(matrix, col);
            }

            PrintMatrix(matrix);
        }

        private static void FireAShot(char[,] matrix, int impactRow, int impactCol, int radius)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if ((cols - impactCol) * (cols - impactCol) +
                        (rows - impactRow) * (rows - impactRow) <= radius * radius)
                    {
                        matrix[rows, cols] = ' ';
                    }
                }
            }
        }

        private static void RunGravity(char[,] matrix, int col)
        {
            while (true)
            {
                bool hasFallen = false;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    char topChar = matrix[row - 1, col];
                    char currentChar = matrix[row, col];
                    if (currentChar == ' ' && topChar != ' ')
                    {
                        matrix[row, col] = topChar;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }

                if (!hasFallen)
	            {
                    break;
	            }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        private static int FillMatrix(int numberOfRows, int numberOfCols, char[,] matrix, string snake, bool isMovingLeft, int currentIndex)
        {
            for (int row = numberOfRows - 1; row >= 0; row--)
            {
                if (isMovingLeft)
                {
                    for (int col = numberOfCols - 1; col >= 0; col--)
                    {
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[row, col] = snake[currentIndex];
                        currentIndex++;
                    }
                }
                else
                {
                    for (int col = 0; col < numberOfCols; col++)
                    {
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }
                        matrix[row, col] = snake[currentIndex];
                        currentIndex++;
                    }
                }
                isMovingLeft = !isMovingLeft;
            }
            return currentIndex;
        }
    }
}
