using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMatrix = new double[,] { 
            { 1, 3 },
            { 5, 7 } };
            var secondMatrix = new double[,] {
            { 4, 2 }, 
            { 1, 5 } };
            var finalMatrix = MultiplyMatrix(firstMatrix, secondMatrix);

            for (int row = 0; row < finalMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < finalMatrix.GetLength(1); col++)
                {
                    Console.Write(finalMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyMatrix(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var maxIndex = firstMatrix.GetLength(1);
            var finalMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int row = 0; row < finalMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < finalMatrix.GetLength(1); col++)
                {
                    for (int index = 0; index < maxIndex; index++)
                    {
                        finalMatrix[row, col] += firstMatrix[row, index] * secondMatrix[index, col];
                    }
                }
            }
            return finalMatrix;
        }
    }
}