using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Star : EnvironmentObject
    {
        private const char StarO = 'O';
        private const int StarImageUpdate = 10;
        private int UpdateCount = 0;
        private static readonly Random randomizer = new Random();
        private char[] StarImageProfiles = new char[] {'O', '@', '0'};

    public Star(int x, int y) : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { StarO } };
        }

        public Star(Rectangle bounds) : base(bounds)
        {
        }

        public override void Update()
        {
            if (this.UpdateCount == StarImageUpdate)
            {
               
                int index = randomizer.Next(0, StarImageProfiles.Length);
                this.ImageProfile = new char[,] { {StarImageProfiles[index]} };
                this.UpdateCount = 0;
            }
            this.UpdateCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
