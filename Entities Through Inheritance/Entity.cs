using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public abstract class Entity
    {
        public Entity(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x, y;
        public abstract void Render();
    }
}
