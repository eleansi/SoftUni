using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamKastolarsProject.Enumerations;

namespace TeamKastolarsProject.CharacterClasses
{
    public class Mage : Entity
    {
        public Mage() : base()
        {
        }

        public Mage(string name, EntityGender gender) : base()
        {
            this.Name = name;
            this.Gender = gender;
            this.health = 2000;
            this.mana = 10000;
            this.wisdom = 8000;
        }

        
    }
}
