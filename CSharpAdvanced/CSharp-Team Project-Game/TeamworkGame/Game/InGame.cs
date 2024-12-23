using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Game
{
    class InGame
    {
        static Random rand = new Random();
        static int menuSelectorPosition = 2;
        static int holeSize = 1;
        static int wallCurrentPosition = Console.WindowWidth - 1;
        static int bonusCurrentPosition = Math.Abs(wallCurrentPosition - Console.WindowWidth / 2 - 1);
        static int bonusCurrentHeight = rand.Next(2, Console.WindowHeight - 2);
        static int currentPlayerPositionRow = Console.WindowHeight / 2;
        static int currentPlayerPositionCol = Console.WindowWidth / 2;
        static byte gravityDirection = 0;
        static bool isDead = false;
        static int score = 0;
        static int lives = 3;
        static char scoreChar = '\u2605';
        static char heartChar = '\u2665';
        static char bonusChar = '\u0001';

        //static Position currentPlayerPosition = new Position(Console.WindowHeight / 2, Console.WindowWidth / 2);
        //static Position newPlyerPosition = currentPlayerPosition;

        //struct Position
        //{
        //    public int row;
        //    public int col;
        //    public Position(int row, int col)
        //    {
        //        this.row = row;
        //        this.col = col;
        //    }
        //}

        public static void PlayGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            // Print Score and Lives
            PrintPosition(heartChar + ": " + lives, 0, 0);
            PrintPosition("Score: " + score, 12, 0);

            int wallTopSize = rand.Next(2, (Console.WindowHeight - 3) - holeSize);
            Console.ForegroundColor = ConsoleColor.Black;

            // Print Frame
            Game.PrintHorizontal(1);
            Game.PrintHorizontal(Console.WindowHeight - 2);

            // Play Game
            while (true)
            {
                // Checks if the wall current position is equals to player position
                if (wallCurrentPosition == currentPlayerPositionCol + 2 && (currentPlayerPositionRow + 1 < wallTopSize || currentPlayerPositionRow > wallTopSize + holeSize))
                {
                    lives--;
                    CheckLives();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    PrintPosition(heartChar + ": " + lives, 0, 0);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 4, Console.WindowHeight / 2 + 1);
                    Console.WriteLine("You have died!");
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 18, Console.WindowHeight / 2 + 2);
                    Console.WriteLine("Nakov knocked you down with the laptop!");
                    wallCurrentPosition = Console.WindowWidth - 1;
                    bonusCurrentPosition = Console.WindowWidth / 2;
                    ConsoleKeyInfo key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Enter)
                    {
                        key = Console.ReadKey();
                    }
                    currentPlayerPositionRow = Console.WindowHeight / 2;
                    ClearWalls(wallTopSize);
                }

                else if (wallCurrentPosition == currentPlayerPositionCol && (currentPlayerPositionRow > wallTopSize || currentPlayerPositionRow < wallTopSize + holeSize))
                {
                    score += 100;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    PrintPosition("Score: " + score, 12, 0);
                }

                // Checks if the wall is in the middle of the console
                if (wallCurrentPosition == Console.WindowWidth / 2)
                {
                    bonusCurrentHeight = rand.Next(2, Console.WindowHeight - 2);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (currentPlayerPositionRow > 2)
                        {
                            Console.SetCursorPosition(currentPlayerPositionCol, currentPlayerPositionRow);
                            Console.Write("   ");
                            currentPlayerPositionRow--;
                        }
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (currentPlayerPositionRow < Console.WindowHeight - 3)
                        {
                            Console.SetCursorPosition(currentPlayerPositionCol, currentPlayerPositionRow);
                            Console.Write("   ");
                            currentPlayerPositionRow++;
                        }
                    }
                }

                else
                {
                    Console.SetCursorPosition(currentPlayerPositionCol, currentPlayerPositionRow);
                    Console.Write("   ");
                    currentPlayerPositionRow++;
                    if (currentPlayerPositionRow > Console.WindowHeight - 3)
                    {
                        lives--;
                        CheckLives();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        PrintPosition(heartChar + ": " + lives, 0, 0);
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 4, Console.WindowHeight / 2 + 1);
                        Console.WriteLine("You have died!");
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 9, Console.WindowHeight / 2 + 2);
                        Console.WriteLine("Nakov has cought you!");
                        ConsoleKeyInfo key = Console.ReadKey();
                        while (key.Key != ConsoleKey.Enter)
                        {
                            key = Console.ReadKey();
                        }
                        currentPlayerPositionRow = Console.WindowHeight / 2;
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 4, Console.WindowHeight / 2 + 1);
                        Console.WriteLine("              ");
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 9, Console.WindowHeight / 2 + 2);
                        Console.WriteLine("                     ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                PrintPlayer();
                Console.ForegroundColor = ConsoleColor.Red;
                PrintWalls(wallTopSize);
                wallCurrentPosition--;
                PrintBonus(bonusCurrentPosition, bonusCurrentHeight);
                bonusCurrentPosition--;

                if (bonusCurrentPosition < 0)
                {
                    bonusChar = ' ';
                    PrintBonus(0, bonusCurrentHeight);
                    bonusCurrentPosition = Console.WindowWidth - 1;
                    bonusChar = '\u0001';
                }
                if (bonusCurrentPosition == currentPlayerPositionCol && (bonusCurrentHeight == currentPlayerPositionRow || bonusCurrentHeight == currentPlayerPositionRow + 1 || bonusCurrentHeight == currentPlayerPositionRow - 1))
                {
                    score += 200;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    PrintPosition("Score: " + score, 12, 0);
                    bonusChar = ' ';
                }
                if (wallCurrentPosition < 0)
                {
                    for (int i = 1; i < Console.WindowHeight - 2; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write("  ");
                    }
                    wallCurrentPosition = Console.WindowWidth - 1;
                    wallTopSize = rand.Next(2, (Console.WindowHeight - 3) - holeSize);
                }
                Thread.Sleep(100);
            }
        }

        private static void CheckLives()
        {
            if (lives < 0)
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2) - 4, Console.WindowHeight / 2 + 1);
                Console.WriteLine("GAME OVER!");
                Console.SetCursorPosition((Console.WindowWidth / 2) - 5, Console.WindowHeight / 2 + 2);
                Console.WriteLine("YOUR SCORE: {0}", score);
                Environment.Exit(0);
            }
        }

        private static void PrintBonus(int left, int top)
        {
            Console.SetCursorPosition(Math.Min(left + 1, Console.WindowWidth - 1), top);
            Console.Write("  ");
            Console.SetCursorPosition(left, top);
            Console.Write(bonusChar);
        }

        static void PrintPlayer()
        {
            Console.SetCursorPosition(currentPlayerPositionCol, currentPlayerPositionRow);
            Console.Write(">O<");
        }

        public static void PrintWalls(int wallTopSize)
        {

            for (int i = 2; i < wallTopSize - 1; i++)
            {
                Console.SetCursorPosition(Math.Min(wallCurrentPosition + 1, Console.WindowWidth - 1), i);
                Console.WriteLine("  ");
                Console.SetCursorPosition(wallCurrentPosition, i);
                Console.Write("||");
            }
            for (int i = wallTopSize + holeSize + 1; i < Console.WindowHeight - 2; i++)
            {
                Console.SetCursorPosition(Math.Min(wallCurrentPosition + 1, Console.WindowWidth - 1), i);
                Console.WriteLine("  ");
                Console.SetCursorPosition(wallCurrentPosition, i);
                Console.Write("||");
            }
        }

        public static void ClearWalls(int wallTopSize)
        {

            for (int i = 2; i < wallTopSize - 1; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, i);
                Console.WriteLine("      ");
            }
            for (int i = wallTopSize + holeSize + 1; i < Console.WindowHeight - 2; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, i);
                Console.WriteLine("      ");
            }
            Console.SetCursorPosition((Console.WindowWidth / 2) - 4, Console.WindowHeight / 2 + 1);
            Console.WriteLine("              ");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 18, Console.WindowHeight / 2 + 2);
            Console.WriteLine("                                       ");
        }

        static void PrintPosition(string text, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }
    }
}