using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECB_EntityFactory
    {
        public static ECB_Entity MakeBall(int x, int y, int dx, int dy)
        {
            ECB_Entity e = new ECB_Entity();
            ECB_CTransform CT = new ECB_CTransform();
            CT.x = x;
            CT.y = y;
            e.AddComponent(CT);
            ECB_CMovement CM = new ECB_CMovement();
            CM.dx = dx;
            CM.dy = dy;
            e.AddComponent(CM);
            e.AddComponent(new ECB_CRender());
            ECB_CColor CC = new ECB_CColor();
            CC.color = Color.Blue;
            e.AddComponent(CC);
            e.AddComponent(new ECB_CCollide());

            return e;
        }
    }
}
