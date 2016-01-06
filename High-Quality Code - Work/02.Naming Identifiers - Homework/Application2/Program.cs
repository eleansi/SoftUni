using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        private static void Main(string[] mainArgs)
        {
            string command = string.Empty;
            char[,] field = GenerateField();
            char[,] bombs = GenerateBombs();
            int counter = 0;
            bool gameOver = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool justStarted = true;
            const int max = 35;
            bool hasWon = false;

            do
            {
                if (justStarted)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try your luck to find the cells without bombs. "
                        + "The command 'top' shows the Score ratings, 'reset' starts a new game, 'exit' closes the game.");
                    PrintFrames(field);
                    justStarted = false;
                }

                Console.Write("Please enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rating(players);
                        break;
                    case "reset":
                        field = GenerateField();
                        bombs = GenerateBombs();
                        PrintFrames(field);
                        gameOver = false;
                        justStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                MakeTurn(field, bombs, row, col);
                                counter++;
                            }

                            if (max == counter)
                            {
                                hasWon = true;
                            }
                            else
                            {
                                PrintFrames(field);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("{0}Invalid command!{0}", Environment.NewLine);
                        break;
                }

                if (gameOver)
                {
                    PrintFrames(bombs);
                    Console.Write("\nHrrrrrr! You died heroically with {0} points. " + "Please enter your name: ", counter);
                    string name = Console.ReadLine();
                    Player player = new Player(name, counter);
                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < player.Points)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Rating(players);

                    field = GenerateField();
                    bombs = GenerateBombs();
                    counter = 0;
                    gameOver = false;
                    justStarted = true;
                }

                if (hasWon)
                {
                    Console.WriteLine("\nGreatings! You have selected 35 cells without loosing any health point.");
                    PrintFrames(bombs);
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, counter);
                    players.Add(player);
                    Rating(players);
                    field = GenerateField();
                    bombs = GenerateBombs();
                    counter = 0;
                    hasWon = false;
                    justStarted = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Greatings to you!");
            Console.Read();
        }

        private static void Rating(List<Player> scores)
        {
            Console.WriteLine("\nScores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, scores[i].Name, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scores!\n");
            }
        }

        private static void MakeTurn(char[,] cell, char[,] bombs, int row, int col)
        {
            char bombsCount = GetBombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            cell[row, col] = bombsCount;
        }

        private static void PrintFrames(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] GenerateBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!bombs.Contains(randomNumber))
                {
                    bombs.Add(randomNumber);
                }
            }

            foreach (int bomb in bombs)
            {
                int col = bomb / cols;
                int row = bomb % cols;
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static void GetNeightborBombs(char[,] cell)
        {
            int col = cell.GetLength(0);
            int row = cell.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (cell[i, j] != '*')
                    {
                        char bombsCount = GetBombsCount(cell, i, j);
                        cell[i, j] = bombsCount;
                    }
                }
            }
        }

        private static char GetBombsCount(char[,] matrix, int row, int col)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (row - 1 >= 0)
            {
                if (matrix[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (matrix[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (matrix[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (matrix[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (matrix[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (matrix[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (matrix[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (matrix[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}