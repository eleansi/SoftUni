using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedSet<char> set = new SortedSet<char>(input);
        var result = input.GroupBy(x => x).OrderBy(x => x.First());
        foreach (var item in result)
        {
            Console.WriteLine("{0}: {1} time/s", item.First(), item.Count());
        }
    }
}

