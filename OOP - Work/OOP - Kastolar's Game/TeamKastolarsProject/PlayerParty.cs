using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamKastolarsProject
{
    public class PlayerParty
    {
        public WorldMapSprite partySprite;
        public CombatPartyMember member1;
        public CombatPartyMember member2;
        public static string name;

        public PlayerParty(Point location, Image image, int ID,
            CombatPartyMember member1)
        {
            partySprite = new WorldMapSprite(location, image, ID);
            this.member1 = member1;
        }

       
    }
}
