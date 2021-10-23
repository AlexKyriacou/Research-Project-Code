using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECS_SRender : ECS_System
    {
        public ECS_SRender(List<ECS_Entity> entities) : base(entities) {  }

        public override void Update()
        {
            foreach(ECS_Entity e in _entities)
            {
                ECS_CTransform transform = e.GetComponent<ECS_CTransform>();
                ECS_CColor color = e.GetComponent<ECS_CColor>();
                if (transform != null)
                {
                    SplashKit.FillCircle(color.color, transform.x, transform.y, 5);
                }
            }
        }
    }
}
