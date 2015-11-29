using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals
{
    public class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Rabbit-rabbit!");
        }
    }
}
