using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split(new[] {' ', '\t'}, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                switch (commandArgs[0])
                {
                    case "sort":
                        ExecuteSortCommand(commandArgs, collection);
                        break; 
                    case "reverse":
                        ExecuteReverseCommand(commandArgs, collection);
                        break;
                    case "rollLeft":
                        ExecuteRollLeftCommand(commandArgs, collection);
                        break;
                    case "rollRight":
                        ExecuteRollRightCommand(commandArgs, collection);
                        break;

                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }

        private static void ExecuteRollRightCommand(string[] commandArgs, List<string> collection)
        {
            int count = int.Parse(commandArgs[1]) % collection.Count;

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                string lastElement = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                collection.Insert(0, lastElement);
            }
        }

        private static void ExecuteRollLeftCommand(string[] commandArgs, List<string> collection)
        {
            int count = int.Parse(commandArgs[1]) % collection.Count;
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                string firstElement = collection[0];
                collection.RemoveAt(0);
                collection.Add(firstElement);
            }
        }

        private static void ExecuteReverseCommand(string[] commandArgs, List<string> collection)
        {
            int startIndex = int.Parse(commandArgs[2]);
            int count = int.Parse(commandArgs[4]);

            if (startIndex < 0 || startIndex >= collection.Count || count < 0 ||
                startIndex + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            collection.Reverse(startIndex, count);

        }

        private static void ExecuteSortCommand(string[] commandArgs, List<string> collection)
        {
            int startIndex = int.Parse(commandArgs[2]);
            int count = int.Parse(commandArgs[4]);

            if (startIndex < 0 || startIndex >= collection.Count || count < 0 || 
                startIndex + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return; 
            }

            collection.Sort(startIndex, count, StringComparer.InvariantCulture);

        }
    }
}
