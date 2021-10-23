using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECS_SCollide:ECS_System
    {
        public ECS_SCollide(List<ECS_Entity> entities) : base(entities) {   }
        public override void Update()
        {
            foreach(ECS_Entity e in _entities)
            {
                ECS_CTransform transform = e.GetComponent<ECS_CTransform>();
                ECS_CMovement movement = e.GetComponent<ECS_CMovement>();
                if(transform != null && movement != null){
                    if (transform.x >= SplashKit.CurrentWindowWidth() || transform.x <= 0)
                    {
                        movement.dx = -movement.dx;
                    }
                    else if (transform.y >= SplashKit.CurrentWindowHeight() || transform.y <= 0)
                    {
                        movement.dy = -movement.dy;
                    }
                }
            }
        }
    }
}
