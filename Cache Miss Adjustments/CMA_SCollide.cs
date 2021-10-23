using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class CMA_SCollide
    {
        public void Update()
        {
            List<CMA_CTransform> transforms = CMA_ComponentManager.GetInstance().transforms;
            List<CMA_CMovement> movements = CMA_ComponentManager.GetInstance().movements;
            for (int i = 0; i < transforms.Count; i++)
            {
                if (transforms[i] != null && movements[i] != null)
                {
                    if (transforms[i].x >= SplashKit.CurrentWindowWidth() || transforms[i].x <= 0)
                    {
                        movements[i].dx = -movements[i].dx;
                    }
                    else if (transforms[i].y >= SplashKit.CurrentWindowHeight() || transforms[i].y <= 0)
                    {
                        movements[i].dy = -movements[i].dy;
                    }
                }
            }
        }
    }
}
