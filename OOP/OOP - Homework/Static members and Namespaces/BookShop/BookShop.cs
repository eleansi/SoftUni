using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookShop
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Kama sutra", "Ne znam ot koi e", 60.00m);
            GoldenEditionBook goldenEd = new GoldenEditionBook("Qka kniga", "Ot men", 110.00m);

            Console.WriteLine(book1);
            Console.WriteLine();
            Console.WriteLine(goldenEd);
        }
    }
}
