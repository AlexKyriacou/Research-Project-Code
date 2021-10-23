using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class ECS_SMovement: ECS_System
    {
        public ECS_SMovement(List<ECS_Entity> entities) : base(entities) { }

        public override void Update()
        {
            foreach (ECS_Entity e in _entities)
            {
                ECS_CTransform transform = e.GetComponent<ECS_CTransform>();
                ECS_CMovement velocity = e.GetComponent<ECS_CMovement>();
                if (transform != null && velocity != null)
                {
                    transform.x += velocity.dx;
                    transform.y += velocity.dy;
                }
            }
        }
    }
}
