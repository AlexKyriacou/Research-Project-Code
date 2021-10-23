using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECS_EntityFactory
    {
        public static ECS_Entity MakeBall(int x, int y, int dx, int dy)
        {
            ECS_Entity e = new ECS_Entity();
            ECS_CTransform CT = new ECS_CTransform();
            CT.x = x;
            CT.y = y;
            e.AddComponent(CT);
            ECS_CMovement CM = new ECS_CMovement();
            CM.dx = dx;
            CM.dy = dy;
            e.AddComponent(CM);
            ECS_CColor CC = new ECS_CColor();
            CC.color = Color.Blue;
            e.AddComponent(CC);
            return e;
        }
    }
}
