using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamKastolarsProject.Enumerations;

namespace TeamKastolarsProject.CharacterClasses
{
    public abstract class Entity
    {
        #region Fields Region

        protected string name;
        protected EntityGender gender;
        protected EntityClass characterClass;
        protected int health;
        protected int level;
        protected int wisdom;
        protected int mana;

        // Modifiers
        protected int healthModifier;
        protected int wisdomModifier;
        protected int manaModifier;

        #endregion

        #region Constructor Region

        public Entity()
        {
            this.Name = "";
            this.Health = 0;
            this.Wisdom = 0;
            this.Mana = 0;
        }
        #endregion

        #region Properties Region

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; } 
        }

        public EntityClass CharacterClass
        {
            get { return this.characterClass; }
            protected set { this.characterClass = value; }
        }

        public EntityGender Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }

        public int Health
        {
            get { return this.health + this.healthModifier; }
            protected set { this.health = value; }
        }

        public int Wisdom
        {
            get { return this.wisdom + this.wisdomModifier; }
            protected set { this.wisdom = value; }
        }

        public int Mana
        {
            get { return this.mana + this.manaModifier; }
            protected set { this.mana = value; }
        }

        #endregion

        #region Methods Region

        #endregion
    }
}
