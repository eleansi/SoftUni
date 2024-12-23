using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamKastolarsProject
{
    public class WorldMapSprite
    {
        public Point location;
        public Image image;
        public int ID;

        public WorldMapSprite(Point location, Image image, int ID)
        {
            this.location = location;
            this.image = image;
            this.ID = ID;
        }

        public void Draw(Graphics device)
        {
            device.DrawImage(image, location);
        }

        public void Move(int x, int y)
        {
            location.X += x;
            location.Y += y;
        }
    }
}
