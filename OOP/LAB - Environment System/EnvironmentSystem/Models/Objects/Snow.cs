using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Snow : EnvironmentObject
    {
        private const int width = 1;
        private const int height = 1;
        private const char SnowImageCharacter = '.';
        public Snow(int x, int y)
            : base(x, y, width, height)
        {
            this.ImageProfile = new char[,] { { SnowImageCharacter } };
            this.CollisionGroup = CollisionGroup.Snow;
        }

        public Snow(Rectangle bounds) : base(bounds)
        {
         }

        public override void Update()
        {
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
