using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals
{
    public class Tomcat : Cat, ISoundProducible
    {
        public Tomcat(string name, int age) : base(name, age, "male")
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Az sum muj");
        }
    }
}
