using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public abstract class DynamicEntity:Entity
    {
        public DynamicEntity(int x, int y, int dx, int dy) : base(x, y)
        {
            this.dx = dx;
            this.dy = dy;
        }
        public int dx, dy;
        public abstract void Update();
        public abstract void Collide();
    }
}
