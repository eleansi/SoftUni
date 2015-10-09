using System;
using System.Text;
using System.Threading;

namespace Game
{

    public class Game
    {

        // Variables
        public static string menuPlay = "Play";
        static string menuExit = "Exit";
        
        static string menuFrame = "o" + new string('-', 18) + "o";
        static int menuSelectorPosition = 0;

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            PrintMainMenu();
        }

        static void PrintLevelMenu()
        {

        }

        public static void PrintMenu(string firstCommand, string secondCommand)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            PrintHorizontal(0);
            PrintHorizontal(Console.WindowHeight - 2);
            PrintVertical(0);
            PrintVertical(Console.WindowWidth - 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (menuFrame.Length / 2), (Console.WindowHeight / 2) - 3 + (menuSelectorPosition * 2));
            Console.Write(menuFrame);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (menuFrame.Length / 2), (Console.WindowHeight / 2) - 3 + (menuSelectorPosition * 2) + 2);
            Console.Write(menuFrame);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (menuFrame.Length / 2), (Console.WindowHeight / 2) - 3 + (menuSelectorPosition * 2) + 1);
            Console.Write(">");
            Console.SetCursorPosition((Console.WindowWidth / 2) + (menuFrame.Length / 2) - 1, (Console.WindowHeight / 2) - 3 + (menuSelectorPosition * 2) + 1);
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.Black;

            if (menuSelectorPosition == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.SetCursorPosition((Console.WindowWidth / 2) - (firstCommand.Length / 2), (Console.WindowHeight / 2) - 2);
            Console.Write(firstCommand);
            Console.ForegroundColor = ConsoleColor.Black;
            if (menuSelectorPosition == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.SetCursorPosition((Console.WindowWidth / 2) - (secondCommand.Length / 2), (Console.WindowHeight / 2));
            Console.Write(secondCommand);
            Console.ForegroundColor = ConsoleColor.Black;
            
        }

        static void PrintMainMenu()
        {
            PrintMenu(menuPlay, menuExit);
            UserChoice();
            PrintMainMenu();
        }

        public static void PrintHorizontal(int padding)
        {
            Console.SetCursorPosition(0, padding);
            Console.Write("o");
            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                Console.SetCursorPosition(i, padding);
                Console.Write("-");
            }
            Console.Write("o");
            Console.SetCursorPosition(5, 5);
        }

        public static void PrintVertical(int padding)
        {
            Console.SetCursorPosition(0, 1);
            for (int i = 1; i < Console.WindowHeight - 2; i++)
            {
                Console.SetCursorPosition(padding, i);
                Console.WriteLine("|");
            }
        }

        static void UserChoice()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (menuSelectorPosition > 0)
                {
                    menuSelectorPosition--;
                }
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                if (menuSelectorPosition < 1)
                {
                    menuSelectorPosition++;
                }
            }
            if (key.Key == ConsoleKey.Enter)
            {
                switch (menuSelectorPosition)
                {
                    case 0:
                        InGame.PlayGame();
                        break;
                    case 1:
                        Environment.Exit(0);
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }

}