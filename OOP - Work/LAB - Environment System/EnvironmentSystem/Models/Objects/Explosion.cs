using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Explosion : Trail
    {
        public Explosion(int x, int y, int lifeTime = 2) : base(x, y, lifeTime)
        {
            this.CollisionGroup = CollisionGroup.Explosion;
        }
    }
}
