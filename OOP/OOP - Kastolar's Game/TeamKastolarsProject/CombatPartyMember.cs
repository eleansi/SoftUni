using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamKastolarsProject
{
    public class CombatPartyMember
    {
        public int health;
        public int attackPower;
        public Image img;
        //
        public List<Skill> skills = new List<Skill>();
        public string name;

        public CombatPartyMember(int health, int attackPower, Image img)
        {
            this.health = health;
            this.attackPower = attackPower;
            this.img = img;

            //
            Skill s = new Skill();
            s.damagePerTurn = 2;
            s.initialDamage = 3;
            s.duration = 1;
            s.name = "Bleed";
            skills.Add(s);
        }

    }
}
