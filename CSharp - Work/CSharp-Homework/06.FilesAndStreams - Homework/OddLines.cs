using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader fileStream = new StreamReader("../../text.txt");
            using (fileStream)
            {
                int currentLine = 0;
                string line = fileStream.ReadLine();
                while (line != null)
                {
                    if (currentLine % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    line = fileStream.ReadLine();
                    currentLine++;
                }
            }
        }
    }
}
