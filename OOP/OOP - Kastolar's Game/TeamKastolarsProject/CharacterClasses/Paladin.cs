using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamKastolarsProject.Enumerations;

namespace TeamKastolarsProject.CharacterClasses
{
    public class Paladin : Entity
    {
        public Paladin() : base()
        {
        }

        public Paladin(string name, EntityGender gender) : base()
        {
            this.Name = name;
            this.Gender = gender;
            this.health = 5000;
            this.mana = 5000;
            this.wisdom = 15000;
        }
    }
}
