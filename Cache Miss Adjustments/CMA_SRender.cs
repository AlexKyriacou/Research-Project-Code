using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class CMA_SRender
    {
        public void Update()
        {
            List<CMA_CTransform> transforms = CMA_ComponentManager.GetInstance().transforms;
            List<CMA_CColor> colors = CMA_ComponentManager.GetInstance().colors;
            for (int i = 0; i < transforms.Count; i++)
            {
                SplashKit.FillCircle(colors[i].color, transforms[i].x, transforms[i].y, 5);
            }
        }
    }
}
