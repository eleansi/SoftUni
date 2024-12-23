using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TeamKastolarsProject
{
    public class Game
    {
        private Form gameForm;
        private CombatGUI combatGUI;
        private WorldMap worldMap;
        private PlayerParty playerParty;
        private PictureBox worldMapSpritePb;
        List<WorldMapForMonsters> worldMapMonsters;

        WorldMapForMonsters monsterInCombat;
        bool inCombat;
        //
        int mapX;
        int mapY;

        public Game(Form form)
        {
            gameForm = form;
            //gameForm.Width = 400;
            //gameForm.Height = 400;
            gameForm.BackColor = Color.White;

            worldMap = new WorldMap(gameForm);
            worldMapMonsters = new List<WorldMapForMonsters>();

            mapX = 0;
            mapY = 0;
            LoadNewMap(0, 0);

            combatGUI = new CombatGUI();
            combatGUI.Visible = true;

            inCombat = false;

            //Add combat party members for this class
            Bitmap bmp = new Bitmap("Paladinn.png");
            playerParty = new PlayerParty(new Point(80, 0), bmp, 1,
                new CombatPartyMember(20, 5, new Bitmap("Paladinn.png")));

            worldMapSpritePb = new PictureBox();
            worldMapSpritePb.Width = gameForm.Width;
            worldMapSpritePb.Height = gameForm.Height;
            worldMapSpritePb.BackColor = Color.Transparent;
            worldMapSpritePb.Parent = gameForm;



            Draw();
        }

        void LoadNewMap(int xMove, int yMove)
        {
            mapX += xMove;
            mapY += yMove;
            worldMap.LoadMap(mapX + " " + mapY);

            LoadMonstersOnMap();
        }

        void LoadMonstersOnMap()
        {
            worldMapMonsters.Clear();

            StreamReader reader = new StreamReader(@"MapEntityData\" + mapX + " " + mapY + ".txt");

            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                for (int x = 0; x < line.Length; x++)
                {
                    if (line[x].ToString() == "1")
                    {
                        worldMapMonsters.Add(new WorldMapForMonsters(new Point(x * 40, y * 40), new Bitmap("Enemy1.png"),
                            0, new CombatPartyMember(10, 5, new Bitmap("Enemy1.png"))));
                    }
                    if (line[x].ToString() == "2")
                    {
                        worldMapMonsters.Add(new WorldMapForMonsters(new Point(x * 40, y * 40), new Bitmap("orc.png"),
                            0, new CombatPartyMember(10, 5, new Bitmap("orc.png"))));
                    }
                    if (line[x].ToString() == "3")
                    {
                        worldMapMonsters.Add(new WorldMapForMonsters(new Point(x * 40, y * 40), new Bitmap("elf.png"),
                            0, new CombatPartyMember(10, 5, new Bitmap("elf.png"))));
                    }

                }
                y++;
            }

        }


        public void HandleKeyPress(KeyEventArgs e)
        {
            //Determine if player can move
            if (!inCombat)
            {
                //
                Point p = new Point(0, 0);

                if (e.KeyCode == Keys.Left) { p = new Point(-40, 0); }
                if (e.KeyCode == Keys.Right) { p = new Point(40, 0); }
                if (e.KeyCode == Keys.Up) { p = new Point(0, -40); }
                if (e.KeyCode == Keys.Down) { p = new Point(0, 40); }

                //
                Point potentialMove = new Point(p.X + playerParty.partySprite.location.X,
                    p.Y + playerParty.partySprite.location.Y);

                if (worldMap.GetWalkableAt(potentialMove))
                {
                    playerParty.partySprite.Move(p.X, p.Y);
                }
                else
                {
                    //Load new map if possible
                    if (potentialMove.X > 40 * 9)
                    {
                        LoadNewMap(1, 0);
                        playerParty.partySprite.Move(-360, 0);
                    }
                    if (potentialMove.X < 0)
                    {
                        LoadNewMap(-1, 0);
                        playerParty.partySprite.Move(360, 0);
                    }
                    if (potentialMove.Y < 0)
                    {
                        LoadNewMap(0, -1);
                        playerParty.partySprite.Move(0, 360);
                    }
                    if (potentialMove.Y > 40 * 8)
                    {
                        LoadNewMap(0, 1);
                        playerParty.partySprite.Move(0, -320);
                    }
                }

            }
            else
            {

                if (!combatGUI.inCombat)
                {
                    monsterInCombat.alive = false;
                    KillMonsterInList(monsterInCombat);
                    inCombat = false;

                }
            }

            Draw();

            DetectCollision();
        }

        void KillMonsterInList(WorldMapForMonsters m1)
        {
            foreach (WorldMapForMonsters m in worldMapMonsters)
            {
                if (m == m1)
                {
                    m.alive = false;
                }
            }
        }

        public void DetectCollision()
        {
            foreach (WorldMapForMonsters m in worldMapMonsters)
            {
                //Check if monster is alive before detecting collision
                if (m.alive && playerParty.partySprite.location == m.location)
                {
                    //Create a reference to monster in combat with
                    monsterInCombat = m;
                    combatGUI.StartCombat(playerParty, monsterInCombat.member);
                    inCombat = true;
                }
            }
        }

        void Draw()
        {
            Graphics device;
            Image img = new Bitmap(gameForm.Width, gameForm.Height);
            device = Graphics.FromImage(img);

            worldMap.DrawMap(device);
            playerParty.partySprite.Draw(device);

            //
            foreach (WorldMapForMonsters m in worldMapMonsters)
            {
                //check if monster is alive before drawing
                if (m.alive)
                {
                    m.Draw(device);
                }
                else
                {
                    break;
                }

            }

            worldMapSpritePb.Image = img;
        }
    }
}
