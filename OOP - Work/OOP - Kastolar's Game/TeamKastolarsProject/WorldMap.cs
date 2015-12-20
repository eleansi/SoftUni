using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamKastolarsProject
{
    class WorldMap
    {

        public Image mapImage;
        public List<Tile> mapTiles;

        public struct Tile
        {
            public Image img;
            public Point loc;
            public bool walkable;
        }

        public WorldMap(Form form)
        {
            mapTiles = new List<Tile>();
            
        }

        public void LoadMap(string mapName)
        {
            mapTiles.Clear();
            StreamReader reader = new StreamReader(@"MapTileData\" + mapName + ".txt");

            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                for (int x = 0; x < line.Length; x++)
                {
                    Tile t = new Tile();
                    t.loc = new Point(x * 40, y * 40);

                    if (line[x].ToString() == "1")
                    {
                        t.img = new Bitmap("GrassTile.png");
                        t.walkable = true;
                    }
                    if (line[x].ToString() == "0")
                    {
                        t.img = new Bitmap("WaterField.png");
                        t.walkable = false;
                    }

                    mapTiles.Add(t);
                }

                y++;
            }
        }

        public void DrawMap(Graphics device)
        {
            foreach (Tile t in mapTiles)
            {
                device.DrawImage(t.img, t.loc);
            }
        }

        public bool GetWalkableAt(Point loc)
        {
            foreach (Tile t in mapTiles)
            {
                if (t.loc == loc)
                {
                    if (t.walkable)
                        return true;
                }
            }

            return false;
        }
    }
}
