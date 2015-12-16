using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using System.Globalization;

    public class UnstableStar : FallingStar
    {
        private int lifeTime;

        public UnstableStar(int x, int y, int width, int height, Point direction, int lifetime = 10)
            : base(x, y, width, height, direction)
        {
            
            this.lifeTime = lifetime;
        }

        public override void Update()
        {
            if (this.lifeTime <= 0)
            {
                this.Exists = false;
                this.lifeTime--;
            }
            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> explosion = new List<EnvironmentObject>();
            if (this.Exists)
            {
                return base.ProduceObjects();

            }
            else
            {
                for (int i = this.Bounds.TopLeft.X - 2; i < this.Bounds.TopLeft.X + 2; i++)
                {
                    for (int j = this.Bounds.TopLeft.Y - 2; j < this.Bounds.TopLeft.Y + 2; j++)
                    {
                        if (!(i == this.Bounds.TopLeft.X && j == this.Bounds.TopLeft.Y))
                        {
                            explosion.Add(new Explosion(i, j, 2));
                        }
                    }
                }
            }
            return explosion;
            
        }
    }
}
