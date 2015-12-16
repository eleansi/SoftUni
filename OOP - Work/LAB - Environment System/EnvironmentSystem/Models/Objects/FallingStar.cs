using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class FallingStar : MovingObject
    {
        public FallingStar(int x, int y,int width, int height, Point direction) : base(x, y, width, height, direction)
        {
            this.ImageProfile = new char[,] { {'O'} };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var fallingStar = collisionInfo.HitObject.CollisionGroup;
            if (fallingStar == CollisionGroup.Ground || fallingStar == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> trails = new List<EnvironmentObject>();
            if (this.Exists)
            {
                trails.Add(new Trail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y));
                trails.Add(new Trail(this.Bounds.TopLeft.X - 2 * this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
                trails.Add(new Trail(this.Bounds.TopLeft.X - 3 * this.Direction.X, this.Bounds.TopLeft.Y - 3 * this.Direction.Y));
            }
            return trails;
        }
    }
}
