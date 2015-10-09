using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ArraySlider
{
    class ArraySlider
    {
        static void Main(string[] args)
        {
            BigInteger[] array = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int currentIndex = 0;

            while (command != "stop")
            {
                string[] commandParameters = command.Split();
                int offset = int.Parse(commandParameters[0]) % array.Length;
                string operation = commandParameters[1];
                int operand = int.Parse(commandParameters[2]);

                if (offset < 0)
                {
                    offset = offset + array.Length;
                }
                currentIndex = (currentIndex + offset) % array.Length;
                PerformOperation(operation, array, currentIndex, operand);

                command = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        static void PerformOperation(string operation, BigInteger[] array, int currentIndex, int operand) 
        {
            switch (operation)
            {
                case "&":
                    array[currentIndex] &= operand;
                    break;
                case "|":
                    array[currentIndex] |= operand;
                    break;
                case "^":
                    array[currentIndex] ^= operand;
                    break;
                case "+":
                    array[currentIndex] += operand;
                    break;
                case "-":
                    array[currentIndex] -= operand;
                    break;
                case "*":
                    array[currentIndex] *= operand;
                    break;
                case "/":
                    array[currentIndex] /= operand;
                    break;
            }

            if (array[currentIndex] < 0)
            {
                array[currentIndex] = 0;
            }
        }
    }
}
