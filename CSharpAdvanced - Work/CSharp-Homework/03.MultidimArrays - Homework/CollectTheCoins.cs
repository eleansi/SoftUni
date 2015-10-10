using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CollectTheCoins
{
    static char[][] matrix;
    static int row;
    static int col;
    static int coins;
    static int walls;
    static int correctRow;
    static int correctCol;
    static void Main()
    {
        
        matrix = new char[4][];
        for (int i = 0; i < matrix.Length; i++)
        {
            char[] input = Console.ReadLine().ToArray();
            matrix[i] = input;
        }
        char[] moves = Console.ReadLine().ToArray();
        MakeMoves(moves);

        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit {0}", walls);
        
    }

    

    static void MakeMoves(char[] moves) 
    {
        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'V')
            {
                row++;
                CheckForCoins();
            }
            else if (moves[i] == '>')
            {
                col++;
                CheckForCoins(); 
            }
            else if (moves[i] == '^')
            {
                row--;
                CheckForCoins(); 
            }
            else if (moves[i] == '<')
            {
                col--;
                CheckForCoins();
            }
        }
    }

    static void CheckForCoins() 
    {
        char currentPosition;
        try
        {
            currentPosition = matrix[col][row];
            if (currentPosition == '$')
            {
                coins++;
            }
            correctRow = row;
            correctCol = col;
        }
        catch (IndexOutOfRangeException exception)
        {
            walls++;
            row = correctRow;
            col = correctCol;
            
        }
    }
}

