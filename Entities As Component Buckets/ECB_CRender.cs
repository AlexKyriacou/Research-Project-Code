using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECB_CRender : ECB_Component
    {
        public override void Update()
        {
            ECB_CTransform transform = entity.GetComponent<ECB_CTransform>();
            ECB_CColor color = entity.GetComponent<ECB_CColor>();
            SplashKit.FillCircle(color.color, transform.x, transform.y, 5);
        }
    }
}
