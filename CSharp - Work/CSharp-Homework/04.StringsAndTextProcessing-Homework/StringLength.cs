using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool twentyChars = input.Length < 20;
            if (twentyChars)
            {
                Console.WriteLine(input + new string('*', 20 - input.Length));
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
