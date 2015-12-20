using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamKastolarsProject
{
    public class WorldMapForMonsters : WorldMapSprite
    {
        public bool isStatic;
        public bool alive;
        public CombatPartyMember member;

        public WorldMapForMonsters(Point location, Image image, int ID, CombatPartyMember member)
            : base(location, image, ID)
        {
            this.member = member;
            isStatic = true;
            alive = true;
            //Loot loot;
        }
    }
}
