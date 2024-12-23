using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals
{
    public class Kitten : Cat, ISoundProducible
    {
        public Kitten(string name, int age) : base(name, age, "female")
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Az sum jena");
        }
    }
}
