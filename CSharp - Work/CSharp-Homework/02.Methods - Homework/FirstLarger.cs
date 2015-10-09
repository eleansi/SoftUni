using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirstLargerThanTheNeighbours
{
    class FirstLarger
    {
        static int[] array;
        static void Main(string[] args)
        {
            array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            bool isGreater = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (GetFirst(i))
                {
                    Console.WriteLine("First larger element is: {0}", i);
                    isGreater = true;
                    break;
                }
            }
            if (!isGreater)
	        {
                Console.WriteLine("-1");
	        }

        }
        static bool GetFirst(int i)
        {
            bool firstLargerElement = false;
            if (i == 0)
            {
                firstLargerElement = array[i] > array[i + 1];
            }
            else if (i == array.Length - 1)
            {
                firstLargerElement = array[i] > array[i - 1];
            }
            else
            {
                firstLargerElement = array[i] > array[i - 1] && array[i] > array[i + 1];
            }
            return firstLargerElement;
        }
    }
}
