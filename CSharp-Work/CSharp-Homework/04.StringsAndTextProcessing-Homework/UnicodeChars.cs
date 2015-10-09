using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeChars
{
    class UnicodeChars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write("\\{0:x4}", (int)ch);
            }
        }
    }
}
