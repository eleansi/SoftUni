using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Trail : EnvironmentObject
    {
        private int lifeTime;
        public Trail(int x, int y, int lifeTime = 1) : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { {'*'} };
            this.lifeTime = lifeTime;
        }

        public Trail(Rectangle bounds) : base(bounds)
        {
        }

        public override void Update()
        {
            this.lifeTime--;
            if (this.lifeTime <= 0)
            {
                this.Exists = false;
            }
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }
    }
}
