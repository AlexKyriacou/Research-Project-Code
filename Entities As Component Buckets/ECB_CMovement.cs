using System;
using System.Collections.Generic;
using System.Text;

namespace ResearchProject
{
    public class ECB_CMovement : ECB_Component
    {
        public int dx, dy;
        public override void Update()
        {
            ECB_CTransform transform = entity.GetComponent<ECB_CTransform>();
            transform.x += dx;
            transform.y += dy;
        }
    }
}
