using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public abstract class ECS_System
    {
        protected List<ECS_Entity> _entities;
        public ECS_System(List<ECS_Entity> entities)
        {
            _entities = entities;
        }
        public abstract void Update();
    }
}
