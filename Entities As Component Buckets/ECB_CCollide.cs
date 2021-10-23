using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECB_CCollide : ECB_Component
    {
        public override void Update()
        {
            ECB_CTransform transform = entity.GetComponent<ECB_CTransform>();
            ECB_CMovement movement = entity.GetComponent<ECB_CMovement>();
            if (transform.x >= SplashKit.CurrentWindowWidth() || transform.x <= 0)
            {
                movement.dx = -movement.dx;
            }
            else if(transform.y >= SplashKit.CurrentWindowHeight() || transform.y <= 0)
            {
                movement.dy = -movement.dy;
            }
        }
    }
}
