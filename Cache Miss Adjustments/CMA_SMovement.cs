using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class CMA_SMovement
    {
        public void Update()
        {
            List<CMA_CTransform> transforms = CMA_ComponentManager.GetInstance().transforms;
            List<CMA_CMovement> movements = CMA_ComponentManager.GetInstance().movements;
            for(int i = 0; i<transforms.Count; i++)
            {
                transforms[i].x += movements[i].dx;
                transforms[i].y += movements[i].dy;
            }
        }
    }
}
